using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoEditor.Functions
{
    class RunCMD
    {
        private static RunCMD instance;

        private RunCMD() { }

        public static RunCMD Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new RunCMD();
                }
                return instance;
            }
            private set
            {
                instance = value;
            }
        }

        public void runCMD(string ffmpegComand)
        {
            using (System.Diagnostics.Process process = new System.Diagnostics.Process())
            {
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal;
                startInfo.FileName = "cmd.exe";
                startInfo.Arguments = "/C ffmpeg " + ffmpegComand;

                process.StartInfo = startInfo;

                process.Start();
                process.WaitForExit();
            }

            //try
            //{
            //    Process.Start("cmd.exe", $@"/k ffmpeg.exe {ffmpegComand}");
            //}
            //catch (Exception e)
            //{
            //    MessageBox.Show(e.Message);
            //}
        }
    }
}
