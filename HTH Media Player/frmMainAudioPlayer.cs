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
    public partial class frmMainAudioPlayer : MetroForm
    {
        public frmMainAudioPlayer(string[] args = null)
        {
            InitializeComponent();
            trbVolumn.Value = 4;
            PlayAudio(args[0].ToString());
        }

        private Audio _audio;

        private string mode = "play";
        private string PlayingPosition, Duration;

        private void tmrDurationPlay_Tick(object sender, EventArgs e)
        {
            PlayingPosition = CalculateTime(_audio.CurrentPosition);
            lblStatus.Text = PlayingPosition + "/" + Duration;

            if (_audio.CurrentPosition >= _audio.Duration)
            {
                tmrDurationPlay.Stop();
                Duration = CalculateTime(_audio.Duration);
                PlayingPosition = "0:00:00";
                lblStatus.Text = PlayingPosition + "/" + Duration;
                _audio.Stop();
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
            if (_audio != null)
            {
                if (_audio.Playing)
                {
                    _audio.Pause();
                    tmrDurationPlay.Stop();

                    btnPlay.BackgroundImage = Properties.Resources.inc_play;
                }
                else
                {
                    _audio.Play();
                    tmrDurationPlay.Start();

                    btnPlay.BackgroundImage = Properties.Resources.inc_pause;
                }
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            _audio.Stop();
            tmrDurationPlay.Stop();
            btnPlay.BackgroundImage = Properties.Resources.inc_play;
            trbDuration.Value = 0;
        }        

        private void trbVolumn_Scroll(object sender, ScrollEventArgs e)
        {
            if (_audio != null)
            {
                _audio.Volume = CalculateVolume();
            }
        }

        private void trbDuration_Scroll(object sender, ScrollEventArgs e)
        {
            if (_audio != null)
            {
                _audio.CurrentPosition = trbDuration.Value;
            }
        }

        private void frmMainVideoPlayer_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_audio != null)
            {
                _audio.Stop();
                tmrDurationPlay.Stop();
                btnPlay.BackgroundImage = Properties.Resources.inc_play;
                trbDuration.Value = 0;
            }
        }

        private void frmMainVideoPlayer_Resize(object sender, EventArgs e)
        {
            pnlAudio.Width = this.Width - 10;
            pnlAudio.Height = this.Height - 120;
        }

        private void PlayAudio(string path)
        {
            if (_audio != null)
            {
                _audio.Stop();
                tmrDurationPlay.Stop();
                btnPlay.BackgroundImage = Properties.Resources.inc_play;
                trbDuration.Value = 0;
            }

            _audio = new Audio(path);

            pnlAudio.BackgroundImage = new Bitmap(path);

            pnlAudio.Width = this.Width - 10;
            pnlAudio.Height = this.Height - 120;

            Duration = CalculateTime(_audio.Duration);
            PlayingPosition = "0:00:00";
            lblStatus.Text = PlayingPosition + "/" + Duration;

            trbDuration.Minimum = 0;
            trbDuration.Maximum = Convert.ToInt32(_audio.Duration);
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
