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
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if(args[1].Contains("-a"))// Open Audio
                Application.Run(new frmMainAudioPlayer(args));

            if (args[1].Contains("-v"))// Open Video
                Application.Run(new frmMainVideoPlayer(args));
        }
    }
}
