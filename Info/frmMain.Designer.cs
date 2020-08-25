namespace Computer_Info
{
    partial class FrmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.notify_Icon = new System.Windows.Forms.NotifyIcon(this.components);
            this.conMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuIbox = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuError = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.LinkLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.conMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // notify_Icon
            // 
            this.notify_Icon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notify_Icon.ContextMenuStrip = this.conMenu;
            this.notify_Icon.Icon = ((System.Drawing.Icon)(resources.GetObject("notify_Icon.Icon")));
            this.notify_Icon.Visible = true;
            this.notify_Icon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Notify_Icon_MouseDoubleClick);
            // 
            // conMenu
            // 
            this.conMenu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.conMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuIbox,
            this.mnuError,
            this.mnuExit});
            this.conMenu.Name = "conMenu";
            this.conMenu.Size = new System.Drawing.Size(228, 70);
            // 
            // mnuIbox
            // 
            this.mnuIbox.Image = ((System.Drawing.Image)(resources.GetObject("mnuIbox.Image")));
            this.mnuIbox.Name = "mnuIbox";
            this.mnuIbox.Size = new System.Drawing.Size(227, 22);
            this.mnuIbox.Text = "Ibox - Product Error Message";
            this.mnuIbox.Click += new System.EventHandler(this.MnuItemIbox_Click);
            // 
            // mnuError
            // 
            this.mnuError.Image = ((System.Drawing.Image)(resources.GetObject("mnuError.Image")));
            this.mnuError.Name = "mnuError";
            this.mnuError.Size = new System.Drawing.Size(227, 22);
            this.mnuError.Text = "Report a Problem";
            this.mnuError.Click += new System.EventHandler(this.MnuItemError_Click);
            // 
            // mnuExit
            // 
            this.mnuExit.Image = ((System.Drawing.Image)(resources.GetObject("mnuExit.Image")));
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(227, 22);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.MnuExit_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblInfo.Font = new System.Drawing.Font("Consolas", 14F);
            this.lblInfo.ForeColor = System.Drawing.Color.Black;
            this.lblInfo.Location = new System.Drawing.Point(92, 9);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Padding = new System.Windows.Forms.Padding(10);
            this.lblInfo.Size = new System.Drawing.Size(186, 82);
            this.lblInfo.TabIndex = 1;
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClose
            // 
            this.btnClose.ActiveLinkColor = System.Drawing.Color.Transparent;
            this.btnClose.AutoSize = true;
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.DisabledLinkColor = System.Drawing.Color.Transparent;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.Transparent;
            this.btnClose.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.btnClose.LinkColor = System.Drawing.Color.Black;
            this.btnClose.Location = new System.Drawing.Point(284, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(16, 17);
            this.btnClose.TabIndex = 100;
            this.btnClose.TabStop = true;
            this.btnClose.Text = "x";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnClose.VisitedLinkColor = System.Drawing.Color.Transparent;
            this.btnClose.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.BtnClose_LinkClicked);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 15000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(300, 100);
            this.ControlBox = false;
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 100);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(300, 100);
            this.Name = "FrmMain";
            this.Opacity = 0.8D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.White;
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.conMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NotifyIcon notify_Icon;
        private System.Windows.Forms.ContextMenuStrip conMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuError;
        private System.Windows.Forms.ToolStripMenuItem mnuIbox;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.LinkLabel btnClose;
        private System.Windows.Forms.Timer timer1;
    }
}

