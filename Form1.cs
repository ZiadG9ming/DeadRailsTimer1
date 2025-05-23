using System;
using System.IO;
using System.Windows.Forms;
using Microsoft.Web.WebView2.Core;
using System.Runtime.InteropServices;
using System.Drawing;
using System.Threading.Tasks; // For Task.Delay

namespace DeadRailsTimer
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private const int HTLEFT = 10;
        private const int HTRIGHT = 11;
        private const int HTTOP = 12;
        private const int HTTOPLEFT = 13;
        private const int HTTOPRIGHT = 14;
        private const int HTBOTTOM = 15;
        private const int HTBOTTOMLEFT = 16;
        private const int HTBOTTOMRIGHT = 17;
        private const int WM_NCHITTEST = 0x84;

        private const int resizeAreaSize = 10;

        public Form1()
        {
            InitializeComponent();
            InitializeWebView();

            Color darkColor = ColorTranslator.FromHtml("#101010");
            this.BackColor = darkColor;
            panelTitleBar.BackColor = darkColor;

            panelTitleBar.SendToBack();
            btnClose.BringToFront();
            btnMinimize.BringToFront();
            btnMaximize.BringToFront();

            panelTitleBar.MouseDown += panelTitleBar_MouseDown;
            panelTitleBar.Paint += panelTitleBar_Paint;
            label1.MouseDown += panelTitleBar_MouseDown;

            btnClose.Click += btnClose_Click;
            btnMinimize.Click += btnMinimize_Click;
            btnMaximize.Click += btnMaximize_Click;
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == WM_NCHITTEST)
            {
                base.WndProc(ref m);
                Point pos = PointToClient(new Point(m.LParam.ToInt32()));

                if (pos.X <= resizeAreaSize)
                {
                    if (pos.Y <= resizeAreaSize)
                        m.Result = (IntPtr)HTTOPLEFT;
                    else if (pos.Y >= ClientSize.Height - resizeAreaSize)
                        m.Result = (IntPtr)HTBOTTOMLEFT;
                    else
                        m.Result = (IntPtr)HTLEFT;
                }
                else if (pos.X >= ClientSize.Width - resizeAreaSize)
                {
                    if (pos.Y <= resizeAreaSize)
                        m.Result = (IntPtr)HTTOPRIGHT;
                    else if (pos.Y >= ClientSize.Height - resizeAreaSize)
                        m.Result = (IntPtr)HTBOTTOMRIGHT;
                    else
                        m.Result = (IntPtr)HTRIGHT;
                }
                else if (pos.Y <= resizeAreaSize)
                {
                    m.Result = (IntPtr)HTTOP;
                }
                else if (pos.Y >= ClientSize.Height - resizeAreaSize)
                {
                    m.Result = (IntPtr)HTBOTTOM;
                }
                return;
            }
            base.WndProc(ref m);
        }

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panelTitleBar_Paint(object sender, PaintEventArgs e)
        {
            if (Control.MouseButtons == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, 0x112, 0xf012, 0);
            }
        }

        private async void InitializeWebView()
        {
            var options = new CoreWebView2EnvironmentOptions();
            var environment = await CoreWebView2Environment.CreateAsync(null, null, options);
            await webViewTracker.EnsureCoreWebView2Async(environment);

            if (webViewTracker.CoreWebView2 != null)
            {
                webViewTracker.CoreWebView2.Settings.IsZoomControlEnabled = true;
                webViewTracker.CoreWebView2.Settings.IsPinchZoomEnabled = false;
            }

            string appDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string htmlFilePath = Path.Combine(appDirectory, "tracker.html");

            if (File.Exists(htmlFilePath))
            {
                webViewTracker.Source = new Uri(htmlFilePath);
            }
            else
            {
                MessageBox.Show($"Error: tracker.html not found at {htmlFilePath}\n" +
                                "Please ensure 'tracker.html' is in the same directory as the application executable.",
                                "File Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            webViewTracker.CoreWebView2.NavigationCompleted += CoreWebView2_NavigationCompleted;
        }

        private void CoreWebView2_NavigationCompleted(object sender, CoreWebView2NavigationCompletedEventArgs e)
        {
            if (e.IsSuccess)
            {
                webViewTracker.ZoomFactor = 0.8;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            AnimateWindowMinimize();
        }

        private async void AnimateWindowMinimize()
        {
            for (int i = 0; i < 10; i++)
            {
                this.Opacity -= 0.1;
                await Task.Delay(10);
            }
            this.WindowState = FormWindowState.Minimized;
            this.Opacity = 1;
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                AnimateWindowResize(FormWindowState.Maximized);
            }
            else
            {
                AnimateWindowResize(FormWindowState.Normal);
            }
        }

        private async void AnimateWindowResize(FormWindowState targetState)
        {
            for (int i = 0; i < 10; i++)
            {
                this.Opacity -= 0.05f;
                await Task.Delay(10);
            }

            this.WindowState = targetState;

            for (int i = 0; i < 10; i++)
            {
                this.Opacity += 0.05f;
                await Task.Delay(10);
            }
        }

        private void webViewTracker_Click(object sender, EventArgs e) { }

        private void textBox1_TextChanged(object sender, EventArgs e) { }

        private void label1_Click(object sender, EventArgs e) { }
    }
}
