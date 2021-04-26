using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VideoEditor.Functions;

namespace VideoEditor
{
    public partial class fVideoAudioCutting : MaterialSkin.Controls.MaterialForm
    {
        public List<List<string>> listInOut = new List<List<string>>();
        public fVideoAudioCutting()
        {
            InitializeComponent();
            tlc_TimeLine_VideoSpliter.SetPreviewWnd((int)pictureBox1.Handle);
        }

        private void btnAddVideo_VideoSpliter_Click(object sender, EventArgs e)
        {
            tlc_TimeLine_VideoSpliter.Clear();
            ofd_OpenVideo_VideoSpliter.Filter = "All Media Files|*.wav;*.aac;*.wma;*.wmv;*.avi;*.mpg;*.mpeg;*.m1v;*.mpa;*.mpe;*.m3u;*.mp4;*.mov;*.3g2;*.3gp2;*.3gp;*.3gpp;*.m4a;*.cda;*.aif;*.aifc;*.aiff;*.mid;*.midi;*.rmi;*.mkv;*.WAV;*.AAC;*.WMA;*.WMV;*.AVI;*.MPG;*.MPEG;*.M1V;*.MP2;*.MP3;*.MPA;*.MPE;*.M3U;*.MP4;*.MOV;*.3G2;*.3GP2;*.3GP;*.3GPP;*.M4A;*.CDA;*.AIF;*.AIFC;*.AIFF;*.MID;*.MIDI;*.RMI;*.MKV";
            if (ofd_OpenVideo_VideoSpliter.ShowDialog() == DialogResult.OK)
            {
                string fileName = ofd_OpenVideo_VideoSpliter.FileName;
                if(fileName.Contains(" "))
                {
                    MessageBox.Show("Tên file không được phép chưa khoảng trắng !");
                    return;
                }
                tlc_TimeLine_VideoSpliter.AddVideoClip(1, fileName, 0, tlc_TimeLine_VideoSpliter.GetMediaDuration(fileName), 0, 0);

                if (!cbWithoutAudio_VideoSplitor.Checked)
                    tlc_TimeLine_VideoSpliter.AddAudioClip(5, fileName, 0, tlc_TimeLine_VideoSpliter.GetMediaDuration(fileName), 0, 1.0f);
            }
        }

        private void bntSplit_VideoSpliter_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(ofd_OpenVideo_VideoSpliter.FileName);
            if (ofd_OpenVideo_VideoSpliter.FileName == "openFileDialog1")
            {
                MessageBox.Show("bạn chưa chọn input !");
                return;
            }

            string filename = string.Empty;
            sfdSave_VideoSpliter.Filter = "MP4 File (*.mp4)|*.mp4||";
            if(sfdSave_VideoSpliter.ShowDialog() == DialogResult.OK)
            {
                filename = sfdSave_VideoSpliter.FileName;
                if (File.Exists(filename))
                {
                    MessageBox.Show("Tên file này đã tồn tại, mời bạn đặt tên khác !");
                    return;
                }
            }
            else
            {
                return;
            }

            float startTime = 0f;
            float stopTime = 0f;
            float mediaTime = 0f;
            int strech = 1;

            string fileName = ofd_OpenVideo_VideoSpliter.FileName;
            tlc_TimeLine_VideoSpliter.GetVideoClip(1, 0, ref fileName, ref startTime, ref stopTime, ref mediaTime, ref strech);
            Console.WriteLine($"{startTime} + {stopTime} + {mediaTime}");

            float duration = stopTime - startTime;

            int hour = (int)(startTime / 3600);
            int minute = (int)(startTime % 3600 / 60);
            int second = (int)(startTime % 3600 % 60);

            string hourStr = hour.ToString();
            string minuteStr = minute.ToString();
            string secondStr = second.ToString();

            if(hourStr.Length < 2)
            {
                hourStr = "0" + hourStr;
            }
            if (minuteStr.Length < 2)
            {
                minuteStr = "0" + minuteStr;
            }
            if (secondStr.Length < 2)
            {
                secondStr = "0" + secondStr;
            }


            string startTimeStap = $"{hourStr}:{minuteStr}:{secondStr}";

            Console.WriteLine($"{hour}:{minute}:{second}");
            Console.WriteLine(startTimeStap);

            WaitFormExample.WaitFormFunc wf = new WaitFormExample.WaitFormFunc();
            wf.Show(this);
            RunCMD.Instance.runCMD($@"-i {ofd_OpenVideo_VideoSpliter.FileName} -ss {startTimeStap} -codec copy -t {duration} {filename}");
            wf.Close();

            List<string> temp = new List<string>();
            temp.Add(ofd_OpenVideo_VideoSpliter.FileName);
            temp.Add(sfdSave_VideoSpliter.FileName);
            this.listInOut.Add(temp);

            //tlc_TimeLine_VideoSpliter.Clear();
            //tlc_TimeLine_VideoSpliter.AddVideoClip();
            //tlc_TimeLine_VideoSpliter.AddAudioClip();
        }

        private void btnAddAudio_VideoSpliter_Click(object sender, EventArgs e)
        {
            tlc_TimeLine_VideoSpliter.Clear();
            ofd_OpenVideo_VideoSpliter.Filter = "Audio (*.mp3,*.acc,*wma)|*.acc;*.mp3;*.wma|All Files (*.*)|*.*";
            if (ofd_OpenVideo_VideoSpliter.ShowDialog() == DialogResult.OK)
            {
                string fileName = ofd_OpenVideo_VideoSpliter.FileName;
                if (fileName.Contains(" "))
                {
                    MessageBox.Show("Tên file không được phép chưa khoảng trắng !");
                }
                tlc_TimeLine_VideoSpliter.AddAudioClip(5, fileName, 0, tlc_TimeLine_VideoSpliter.GetMediaDuration(fileName), 0, 1.0f);
            }
        }

        private void btnStop_VideoSpliter_Click(object sender, EventArgs e)
        {
            tlc_TimeLine_VideoSpliter.Stop();
        }

        private void btnClear_VideoSpliter_Click(object sender, EventArgs e)
        {
            tlc_TimeLine_VideoSpliter.Clear();
        }

        private void btnPausePlay_VideoSpliter_Click(object sender, EventArgs e)
        {
            if (tlc_TimeLine_VideoSpliter.IsPause)
                tlc_TimeLine_VideoSpliter.Play();
            else if (tlc_TimeLine_VideoSpliter.IsPlaying)
            {
                tlc_TimeLine_VideoSpliter.Pause();
            }
            else
            {
                tlc_TimeLine_VideoSpliter.Play();
            }
        }

        private void cbbScale_VideoSpliter_SelectedIndexChanged(object sender, EventArgs e)
        {
            tlc_TimeLine_VideoSpliter.SetScale(float.Parse(cbbScale_VideoSpliter.SelectedItem.ToString()));
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fVideoAudioCutting_Load(object sender, EventArgs e)
        {

        }
    }
}
