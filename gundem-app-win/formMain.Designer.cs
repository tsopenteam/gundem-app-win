namespace gundem_app_win
{
    partial class formMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMain));
            this.mediaPlayerPodcast = new AxWMPLib.AxWindowsMediaPlayer();
            this.listBoxPodcast = new System.Windows.Forms.ListBox();
            this.txtAppInfo = new System.Windows.Forms.TextBox();
            this.lblStaticLog = new System.Windows.Forms.Label();
            this.lblLog = new System.Windows.Forms.Label();
            this.lblCurrentPodcast = new System.Windows.Forms.Label();
            this.btnUpdateList = new System.Windows.Forms.Button();
            this.lblPodcastCount = new System.Windows.Forms.Label();
            this.linkGithub = new System.Windows.Forms.LinkLabel();
            this.linkWeb = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.mediaPlayerPodcast)).BeginInit();
            this.SuspendLayout();
            // 
            // mediaPlayerPodcast
            // 
            this.mediaPlayerPodcast.Enabled = true;
            this.mediaPlayerPodcast.Location = new System.Drawing.Point(12, 12);
            this.mediaPlayerPodcast.Name = "mediaPlayerPodcast";
            this.mediaPlayerPodcast.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("mediaPlayerPodcast.OcxState")));
            this.mediaPlayerPodcast.Size = new System.Drawing.Size(636, 101);
            this.mediaPlayerPodcast.TabIndex = 0;
            // 
            // listBoxPodcast
            // 
            this.listBoxPodcast.FormattingEnabled = true;
            this.listBoxPodcast.Location = new System.Drawing.Point(12, 142);
            this.listBoxPodcast.Name = "listBoxPodcast";
            this.listBoxPodcast.Size = new System.Drawing.Size(636, 264);
            this.listBoxPodcast.TabIndex = 1;
            this.listBoxPodcast.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxPodcast_MouseDoubleClick);
            // 
            // txtAppInfo
            // 
            this.txtAppInfo.BackColor = System.Drawing.Color.Silver;
            this.txtAppInfo.Enabled = false;
            this.txtAppInfo.ForeColor = System.Drawing.Color.Black;
            this.txtAppInfo.Location = new System.Drawing.Point(12, 467);
            this.txtAppInfo.Name = "txtAppInfo";
            this.txtAppInfo.Size = new System.Drawing.Size(636, 20);
            this.txtAppInfo.TabIndex = 2;
            this.txtAppInfo.Text = "tsopenteam - 2020";
            this.txtAppInfo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblStaticLog
            // 
            this.lblStaticLog.AutoSize = true;
            this.lblStaticLog.ForeColor = System.Drawing.Color.Black;
            this.lblStaticLog.Location = new System.Drawing.Point(12, 451);
            this.lblStaticLog.Name = "lblStaticLog";
            this.lblStaticLog.Size = new System.Drawing.Size(37, 13);
            this.lblStaticLog.TabIndex = 3;
            this.lblStaticLog.Text = "İşlem: ";
            // 
            // lblLog
            // 
            this.lblLog.AutoSize = true;
            this.lblLog.ForeColor = System.Drawing.Color.DimGray;
            this.lblLog.Location = new System.Drawing.Point(46, 451);
            this.lblLog.Name = "lblLog";
            this.lblLog.Size = new System.Drawing.Size(16, 13);
            this.lblLog.TabIndex = 4;
            this.lblLog.Text = "...";
            // 
            // lblCurrentPodcast
            // 
            this.lblCurrentPodcast.ForeColor = System.Drawing.Color.Firebrick;
            this.lblCurrentPodcast.Location = new System.Drawing.Point(12, 116);
            this.lblCurrentPodcast.Name = "lblCurrentPodcast";
            this.lblCurrentPodcast.Size = new System.Drawing.Size(636, 23);
            this.lblCurrentPodcast.TabIndex = 5;
            this.lblCurrentPodcast.Text = "...";
            this.lblCurrentPodcast.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnUpdateList
            // 
            this.btnUpdateList.Location = new System.Drawing.Point(455, 412);
            this.btnUpdateList.Name = "btnUpdateList";
            this.btnUpdateList.Size = new System.Drawing.Size(193, 23);
            this.btnUpdateList.TabIndex = 6;
            this.btnUpdateList.Text = "Podcast Listesini Güncelle";
            this.btnUpdateList.UseVisualStyleBackColor = true;
            this.btnUpdateList.Click += new System.EventHandler(this.btnUpdateList_Click);
            // 
            // lblPodcastCount
            // 
            this.lblPodcastCount.AutoSize = true;
            this.lblPodcastCount.Location = new System.Drawing.Point(12, 409);
            this.lblPodcastCount.Name = "lblPodcastCount";
            this.lblPodcastCount.Size = new System.Drawing.Size(16, 13);
            this.lblPodcastCount.TabIndex = 7;
            this.lblPodcastCount.Text = "...";
            // 
            // linkGithub
            // 
            this.linkGithub.AutoSize = true;
            this.linkGithub.Location = new System.Drawing.Point(12, 490);
            this.linkGithub.Name = "linkGithub";
            this.linkGithub.Size = new System.Drawing.Size(38, 13);
            this.linkGithub.TabIndex = 8;
            this.linkGithub.TabStop = true;
            this.linkGithub.Text = "Github";
            this.linkGithub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkGithub_LinkClicked);
            // 
            // linkWeb
            // 
            this.linkWeb.AutoSize = true;
            this.linkWeb.Location = new System.Drawing.Point(56, 490);
            this.linkWeb.Name = "linkWeb";
            this.linkWeb.Size = new System.Drawing.Size(30, 13);
            this.linkWeb.TabIndex = 9;
            this.linkWeb.TabStop = true;
            this.linkWeb.Text = "Web";
            this.linkWeb.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkWeb_LinkClicked);
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 510);
            this.Controls.Add(this.linkWeb);
            this.Controls.Add(this.linkGithub);
            this.Controls.Add(this.lblPodcastCount);
            this.Controls.Add(this.btnUpdateList);
            this.Controls.Add(this.lblCurrentPodcast);
            this.Controls.Add(this.lblLog);
            this.Controls.Add(this.lblStaticLog);
            this.Controls.Add(this.txtAppInfo);
            this.Controls.Add(this.listBoxPodcast);
            this.Controls.Add(this.mediaPlayerPodcast);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "formMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Teknoseyir Haftalık Gündemleri";
            ((System.ComponentModel.ISupportInitialize)(this.mediaPlayerPodcast)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer mediaPlayerPodcast;
        private System.Windows.Forms.ListBox listBoxPodcast;
        private System.Windows.Forms.TextBox txtAppInfo;
        private System.Windows.Forms.Label lblStaticLog;
        private System.Windows.Forms.Label lblLog;
        private System.Windows.Forms.Label lblCurrentPodcast;
        private System.Windows.Forms.Button btnUpdateList;
        private System.Windows.Forms.Label lblPodcastCount;
        private System.Windows.Forms.LinkLabel linkGithub;
        private System.Windows.Forms.LinkLabel linkWeb;
    }
}