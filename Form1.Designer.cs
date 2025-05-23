namespace DeadRailsTimer
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.webViewTracker = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.webViewTracker)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // webViewTracker
            // 
            this.webViewTracker.AccessibleRole = System.Windows.Forms.AccessibleRole.Document;
            this.webViewTracker.AllowExternalDrop = true;
            this.webViewTracker.CreationProperties = null;
            this.webViewTracker.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webViewTracker.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.webViewTracker.Location = new System.Drawing.Point(0, 41);
            this.webViewTracker.Name = "webViewTracker";
            this.webViewTracker.Size = new System.Drawing.Size(454, 670);
            this.webViewTracker.TabIndex = 1;
            this.webViewTracker.ZoomFactor = 1D;
            this.webViewTracker.Click += new System.EventHandler(this.webViewTracker_Click);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.Controls.Add(this.label1);
            this.panelTitleBar.Controls.Add(this.button1);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelTitleBar.Location = new System.Drawing.Point(0, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(454, 47);
            this.panelTitleBar.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::DeadRailsTimer.Properties.Resources.Locomotive_au_coucher_du_soleil;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(7, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 31);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImage = global::DeadRailsTimer.Properties.Resources.image;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnClose.FlatAppearance.BorderSize = 3;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.ForeColor = System.Drawing.Color.Black;
            this.btnClose.Location = new System.Drawing.Point(417, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(37, 31);
            this.btnClose.TabIndex = 6;
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.BackColor = System.Drawing.Color.Transparent;
            this.btnMaximize.BackgroundImage = global::DeadRailsTimer.Properties.Resources.image__1_;
            this.btnMaximize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMaximize.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnMaximize.FlatAppearance.BorderSize = 3;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMaximize.ForeColor = System.Drawing.Color.Black;
            this.btnMaximize.Location = new System.Drawing.Point(380, 4);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(33, 31);
            this.btnMaximize.TabIndex = 5;
            this.btnMaximize.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnMaximize.UseVisualStyleBackColor = false;
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.BackgroundImage = global::DeadRailsTimer.Properties.Resources.image__2_;
            this.btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMinimize.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnMinimize.FlatAppearance.BorderSize = 3;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMinimize.ForeColor = System.Drawing.Color.Black;
            this.btnMinimize.Location = new System.Drawing.Point(343, 4);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(33, 31);
            this.btnMinimize.TabIndex = 2;
            this.btnMinimize.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnMinimize.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Chocolate;
            this.label1.Location = new System.Drawing.Point(43, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dead Rails Tracker";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(454, 711);
            this.ControlBox = false;
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnMaximize);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.webViewTracker);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dead Rails Monitor";
            ((System.ComponentModel.ISupportInitialize)(this.webViewTracker)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Microsoft.Web.WebView2.WinForms.WebView2 webViewTracker;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}

