namespace HTH_Media_Player
{
    partial class frmMainAudioPlayer
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
            this.tmrDurationPlay = new System.Windows.Forms.Timer(this.components);
            this.trbVolumn = new MetroFramework.Controls.MetroTrackBar();
            this.trbDuration = new MetroFramework.Controls.MetroTrackBar();
            this.lblStatus = new MetroFramework.Controls.MetroLabel();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.pnlAudio = new MetroFramework.Controls.MetroPanel();
            this.btnFullScreen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tmrDurationPlay
            // 
            this.tmrDurationPlay.Tick += new System.EventHandler(this.tmrDurationPlay_Tick);
            // 
            // trbVolumn
            // 
            this.trbVolumn.BackColor = System.Drawing.Color.Transparent;
            this.trbVolumn.Location = new System.Drawing.Point(266, 307);
            this.trbVolumn.Name = "trbVolumn";
            this.trbVolumn.Size = new System.Drawing.Size(75, 23);
            this.trbVolumn.TabIndex = 0;
            this.trbVolumn.Scroll += new System.Windows.Forms.ScrollEventHandler(this.trbVolumn_Scroll);
            // 
            // trbDuration
            // 
            this.trbDuration.BackColor = System.Drawing.Color.Transparent;
            this.trbDuration.Location = new System.Drawing.Point(87, 259);
            this.trbDuration.Name = "trbDuration";
            this.trbDuration.Size = new System.Drawing.Size(254, 23);
            this.trbDuration.TabIndex = 2;
            this.trbDuration.Scroll += new System.Windows.Forms.ScrollEventHandler(this.trbDuration_Scroll);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(252, 336);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(76, 19);
            this.lblStatus.TabIndex = 3;
            this.lblStatus.Text = "00:00/00:00";
            // 
            // btnPlay
            // 
            this.btnPlay.BackgroundImage = global::HTH_Media_Player.Properties.Resources.inc_play;
            this.btnPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPlay.Location = new System.Drawing.Point(103, 307);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(32, 32);
            this.btnPlay.TabIndex = 4;
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnStop
            // 
            this.btnStop.BackgroundImage = global::HTH_Media_Player.Properties.Resources.inc_stop;
            this.btnStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStop.Location = new System.Drawing.Point(172, 307);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(32, 32);
            this.btnStop.TabIndex = 4;
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // pnlAudio
            // 
            this.pnlAudio.HorizontalScrollbarBarColor = true;
            this.pnlAudio.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlAudio.HorizontalScrollbarSize = 10;
            this.pnlAudio.Location = new System.Drawing.Point(23, 63);
            this.pnlAudio.Name = "pnlAudio";
            this.pnlAudio.Size = new System.Drawing.Size(330, 166);
            this.pnlAudio.TabIndex = 5;
            this.pnlAudio.VerticalScrollbarBarColor = true;
            this.pnlAudio.VerticalScrollbarHighlightOnWheel = false;
            this.pnlAudio.VerticalScrollbarSize = 10;
            // 
            // 
            // frmMainVideoPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 375);
            this.Controls.Add(this.btnFullScreen);
            this.Controls.Add(this.pnlAudio);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.trbDuration);
            this.Controls.Add(this.trbVolumn);
            this.Name = "frmMainAudioPlayer";
            this.Text = "frmMainAudioPlayer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMainVideoPlayer_FormClosing);
            this.Resize += new System.EventHandler(this.frmMainVideoPlayer_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Timer tmrDurationPlay;
        private MetroFramework.Controls.MetroTrackBar trbVolumn;
        private MetroFramework.Controls.MetroTrackBar trbDuration;
        private MetroFramework.Controls.MetroLabel lblStatus;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnStop;
        private MetroFramework.Controls.MetroPanel pnlAudio;
        private System.Windows.Forms.Button btnFullScreen;

        #endregion
    }
}

