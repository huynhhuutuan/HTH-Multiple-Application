using MetroFramework.Forms;
using Microsoft.DirectX.AudioVideoPlayback;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HTH_Media_Player
{
    public partial class frmMainVideoPlayer : MetroForm
    {
        public frmMainVideoPlayer(string[] args = null)
        {
            InitializeComponent();
            trbVolumn.Value = 4;
            PlayVideo(args[0].ToString());
        }

        private Video _video;

        private string mode = "play";
        private string PlayingPosition, Duration;

        private void tmrDurationPlay_Tick(object sender, EventArgs e)
        {
            PlayingPosition = CalculateTime(_video.CurrentPosition);
            lblStatus.Text = PlayingPosition + "/" + Duration;

            if (_video.CurrentPosition >= _video.Duration)
            {
                tmrDurationPlay.Stop();
                Duration = CalculateTime(_video.Duration);
                PlayingPosition = "0:00:00";
                lblStatus.Text = PlayingPosition + "/" + Duration;
                _video.Stop();
                btnPlay.BackgroundImage = Properties.Resources.inc_play;
                trbDuration.Value = 0;
            }
            else
            {
                if (trbDuration.Value <= trbDuration.Maximum)
                    trbDuration.Value += 1;
            }

            lblStatus.Update();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (_video != null)
            {
                if (_video.Playing)
                {
                    _video.Pause();
                    tmrDurationPlay.Stop();

                    btnPlay.BackgroundImage = Properties.Resources.inc_play;
                }
                else
                {
                    _video.Play();
                    tmrDurationPlay.Start();

                    btnPlay.BackgroundImage = Properties.Resources.inc_pause;
                }
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            _video.Stop();
            tmrDurationPlay.Stop();
            btnPlay.BackgroundImage = Properties.Resources.inc_play;
            trbDuration.Value = 0;
        }

        private void btnFullScreen_Click(object sender, EventArgs e)
        {
            if (!_video.Fullscreen)
                _video.Fullscreen = true;
            else
                _video.Fullscreen = false;
        }

        private void trbVolumn_Scroll(object sender, ScrollEventArgs e)
        {
            if (_video != null)
            {
                _video.Audio.Volume = CalculateVolume();
            }
        }

        private void trbDuration_Scroll(object sender, ScrollEventArgs e)
        {
            if (_video != null)
            {
                _video.CurrentPosition = trbDuration.Value;
            }
        }

        private void frmMainVideoPlayer_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_video != null)
            {
                _video.Stop();
                tmrDurationPlay.Stop();
                btnPlay.BackgroundImage = Properties.Resources.inc_play;
                trbDuration.Value = 0;
            }
        }

        private void frmMainVideoPlayer_Resize(object sender, EventArgs e)
        {
            pnlVideo.Width = this.Width - 10;
            pnlVideo.Height = this.Height - 120;
        }

        private void PlayVideo(string path)
        {
            if (_video != null)
            {
                _video.Stop();
                tmrDurationPlay.Stop();
                btnPlay.BackgroundImage = Properties.Resources.inc_play;
                trbDuration.Value = 0;
            }

            _video = new Video(path);

            _video.Owner = pnlVideo;

            pnlVideo.Width = this.Width - 10;
            pnlVideo.Height = this.Height - 120;

            Duration = CalculateTime(_video.Duration);
            PlayingPosition = "0:00:00";
            lblStatus.Text = PlayingPosition + "/" + Duration;

            trbDuration.Minimum = 0;
            trbDuration.Maximum = Convert.ToInt32(_video.Duration);
        }

        public string CalculateTime(double Time)
        {
            string mm, ss, CalculatedTime;
            int h, m, s, T;

            Time = Math.Round(Time);
            T = Convert.ToInt32(Time);

            h = (T / 3600);
            T = T % 3600;
            m = (T / 60);
            s = T % 60;

            if (m < 10)
                mm = string.Format("0{0}", m);
            else
                mm = m.ToString();
            if (s < 10)
                ss = string.Format("0{0}", s);
            else
                ss = s.ToString();

            CalculatedTime = string.Format("{0}:{1}:{2}", h, mm, ss);

            return CalculatedTime;
        }

        public int CalculateVolume()
        {
            switch (trbVolumn.Value)
            {
                case 1:
                    return -1500;
                case 2:
                    return -1000;
                case 3:
                    return -700;
                case 4:
                    return -600;
                case 5:
                    return -500;
                case 6:
                    return -400;
                case 7:
                    return -300;
                case 8:
                    return -200;
                case 9:
                    return -100;
                case 10:
                    return 0;
                default:
                    return -10000;
            }
        }
    }
}
