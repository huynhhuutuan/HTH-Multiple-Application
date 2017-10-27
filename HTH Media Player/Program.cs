using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HTH_Media_Player
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args = null)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if(args.Length < 1)
            {
                Application.Run(new frmMain());
            }
            else
                switch (args[1] = "")
                {
                    case "-a":// Open Audio
                        Application.Run(new frmMainAudioPlayer(args));
                        break;
                    case "-v":// Open Video
                        Application.Run(new frmMainVideoPlayer(args));
                        break;

                    default:
                        Application.Run(new frmMain());
                        break;
                }
        }
    }
}
