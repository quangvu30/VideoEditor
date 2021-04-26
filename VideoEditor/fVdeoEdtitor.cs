using MaterialSkin;
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

namespace VideoEditor
{
    public partial class fVdeoEdtitor : MaterialSkin.Controls.MaterialForm
    {
        MaterialSkinManager skinManager = MaterialSkinManager.Instance;

        public List<List<string>> listInOut = new List<List<string>>();
        public List<string> inputSource = new List<string>();
        public fVdeoEdtitor()
        {
            InitializeComponent();

            //Init skin
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Green900, MaterialSkin.Primary.BlueGrey900, MaterialSkin.Primary.Blue500, MaterialSkin.Accent.Orange700, MaterialSkin.TextShade.WHITE);
            tlc_TimeLine_VideoEditor.SetPreviewWnd((int)pbPreview_VideoEditor.Handle);
        }

        private void btnAddVideo_VideoEditor_Click(object sender, EventArgs e)
        {
            ofd_OpenVideo_VideoEditor.Filter = "All Media Files|*.wav;*.aac;*.wma;*.wmv;*.avi;*.mpg;*.mpeg;*.m1v;*.mp2;*.mp3;*.mpa;*.mpe;*.m3u;*.mp4;*.mov;*.3g2;*.3gp2;*.3gp;*.3gpp;*.m4a;*.cda;*.aif;*.aifc;*.aiff;*.mid;*.midi;*.rmi;*.mkv;*.WAV;*.AAC;*.WMA;*.WMV;*.AVI;*.MPG;*.MPEG;*.M1V;*.MP2;*.MP3;*.MPA;*.MPE;*.M3U;*.MP4;*.MOV;*.3G2;*.3GP2;*.3GP;*.3GPP;*.M4A;*.CDA;*.AIF;*.AIFC;*.AIFF;*.MID;*.MIDI;*.RMI;*.MKV";
            if (ofd_OpenVideo_VideoEditor.ShowDialog() == DialogResult.OK)
            {
                string fileName = ofd_OpenVideo_VideoEditor.FileName;
                if (ofd_OpenVideo_VideoEditor.FileName.Contains(" "))
                {
                    MessageBox.Show("Tên file không được phép chưa khoảng trắng !");
                    return;
                }
                inputSource.Add(ofd_OpenVideo_VideoEditor.FileName);
                tlc_TimeLine_VideoEditor.AddVideoClip(1, fileName, 0, tlc_TimeLine_VideoEditor.GetMediaDuration(fileName), 0, 0);

                if(!cbWithoutAudio_VideoEditor.Checked)
                    tlc_TimeLine_VideoEditor.AddAudioClip(5, fileName, 0, tlc_TimeLine_VideoEditor.GetMediaDuration(fileName), 0, 1.0f);
            }
           
        }

        private void btnPlay_Pause_VideoEditor_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("!");
            if (tlc_TimeLine_VideoEditor.IsPause)
                tlc_TimeLine_VideoEditor.Play();
            else if(tlc_TimeLine_VideoEditor.IsPlaying)
            {
                tlc_TimeLine_VideoEditor.Pause();
            }
            else
            {
                tlc_TimeLine_VideoEditor.Play();
            }
        }

        private void btnStop_VideoEditor_Click(object sender, EventArgs e)
        {
            tlc_TimeLine_VideoEditor.Stop();
        }

        private void btnAddAudio_VideoEditor_Click(object sender, EventArgs e)
        {
            ofd_OpenVideo_VideoEditor.Filter = "Audio (*.mp3,*.acc,*wma)|*.acc;*.mp3;*.wma|All Files (*.*)|*.*";
            if (ofd_OpenVideo_VideoEditor.ShowDialog() == DialogResult.OK)
            {
                if (ofd_OpenVideo_VideoEditor.FileName.Contains(" "))
                {
                    MessageBox.Show("Tên file không được phép chưa khoảng trắng !");
                    return;
                }
                inputSource.Add(ofd_OpenVideo_VideoEditor.FileName);
                string fileName = ofd_OpenVideo_VideoEditor.FileName;
                tlc_TimeLine_VideoEditor.AddAudioClip(5, fileName, 0, tlc_TimeLine_VideoEditor.GetMediaDuration(fileName), 0, 1.0f);
            }
        }

        private void bntAddImages_VideoEditor_Click(object sender, EventArgs e)
        {
            ofd_OpenVideo_VideoEditor.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            if (ofd_OpenVideo_VideoEditor.FileName.Contains(" "))
            {
                MessageBox.Show("Tên file không được phép chưa khoảng trắng !");
                return;
            }
            if (ofd_OpenVideo_VideoEditor.ShowDialog() == DialogResult.OK)
            {
                string fileName = ofd_OpenVideo_VideoEditor.FileName;
                inputSource.Add(ofd_OpenVideo_VideoEditor.FileName);

                tlc_TimeLine_VideoEditor.SetVideoTrackResolution(1024, 768);

                // mỗi ảnh mặc định xuất hiện 10s nếu k kéo dài
                tlc_TimeLine_VideoEditor.AddImageClip(3, fileName, 0, 10, 0);
            }
            
        }

        private void fVdeoEdtitor_FormClosing(object sender, FormClosingEventArgs e)
        {
            tlc_TimeLine_VideoEditor.Stop();
        }

        private void btnExportToMp4_VidieoEditor_Click(object sender, EventArgs e)
        {
            tlc_TimeLine_VideoEditor.OutputType = 2;
            tlc_TimeLine_VideoEditor.MP4Height = 768;
            tlc_TimeLine_VideoEditor.MP4Width = 1024;

            sfd_ExportVideo_VideoEditor.Filter = "MP4 File (*.mp4)|*.mp4||";

            if(sfd_ExportVideo_VideoEditor.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(sfd_ExportVideo_VideoEditor.FileName))
                {
                    MessageBox.Show("Tên file đã tồn tại !");
                    return;
                }
                int result = tlc_TimeLine_VideoEditor.Save(sfd_ExportVideo_VideoEditor.FileName);
            }
            else
            {
                return;
            }

            List<string> temp = new List<string>();
            temp.AddRange(inputSource);
            temp.Add(sfd_ExportVideo_VideoEditor.FileName);
            listInOut.Add(temp);
        }

        private void tlc_TimeLine_VideoEditor_OnConvertProgress(object sender, AxTimelineAxLib._ITimelineControlEvents_OnConvertProgressEvent e)
        {
            pb_ExportProcess_VideoEditor.Value = e.progress;
        }

        private void btnClear_VideoEditor_Click(object sender, EventArgs e)
        {
            //string temp = tlc_TimeLine_VideoEditor.Get
            //MessageBox.Show(temp);
            tlc_TimeLine_VideoEditor.Clear();
        }

        private void cbbTimeLineScale_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            tlc_TimeLine_VideoEditor.SetScale(float.Parse(cbbTimeLineScale.SelectedItem.ToString()));
        }

        private void tlc_TimeLine_VideoEditor_OnConvertCompleted(object sender, EventArgs e)
        {
            MessageBox.Show("Tiến trình đã hoàn tất !");
            pb_ExportProcess_VideoEditor.Value = 0;
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
