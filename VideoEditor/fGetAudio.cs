using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VideoEditor.Functions;
using WaitFormExample;

namespace VideoEditor
{
    public partial class fGetAudio : MaterialSkin.Controls.MaterialForm
    {
        public List<List<string>> listInOut = new List<List<string>>();
        public fGetAudio()
        {
            InitializeComponent();
        }

        private void btnBrowseInput_GetAudio_Click(object sender, EventArgs e)
        {
            ofdChooseInput_GetAudio.Filter = "All Media Files|*.wav;*.aac;*.wma;*.wmv;*.avi;*.mpg;*.mpeg;*.m1v;*.mp2;*.mp3;*.mpa;*.mpe;*.m3u;*.mp4;*.mov;*.3g2;*.3gp2;*.3gp;*.3gpp;*.m4a;*.cda;*.aif;*.aifc;*.aiff;*.mid;*.midi;*.rmi;*.mkv;*.WAV;*.AAC;*.WMA;*.WMV;*.AVI;*.MPG;*.MPEG;*.M1V;*.MP2;*.MP3;*.MPA;*.MPE;*.M3U;*.MP4;*.MOV;*.3G2;*.3GP2;*.3GP;*.3GPP;*.M4A;*.CDA;*.AIF;*.AIFC;*.AIFF;*.MID;*.MIDI;*.RMI;*.MKV";
            DialogResult d = ofdChooseInput_GetAudio.ShowDialog();
            if (d == DialogResult.OK)
            {
                if (ofdChooseInput_GetAudio.FileName.Contains(" "))
                {
                    MessageBox.Show("Tên file không được phép chưa khoảng trắng !");
                    return;
                }
                txtInputFilePath_GetAudio.Text = ofdChooseInput_GetAudio.FileName;
            }
        }

        private void btnBrowseOutput_GetAudio_Click(object sender, EventArgs e)
        {
            sfdOutputFolder_GetAudio.Filter = "Audio (*.mp3)|*.mp3|All Files (*.*)|*.*";
            DialogResult d = sfdOutputFolder_GetAudio.ShowDialog();
            if (d == DialogResult.OK)
            {
                if (File.Exists(sfdOutputFolder_GetAudio.FileName))
                {
                    if(MessageBox.Show("Tên file đã tồn tại, bạn có muốn ghi đè không !", "thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        File.Delete(sfdOutputFolder_GetAudio.FileName);
                        return;
                    }

                }
                txtOutputFilePath_GetAudio.Text = sfdOutputFolder_GetAudio.FileName;
            }
        }

        private void btnExec_GetAuido_Click(object sender, EventArgs e)
        {
            string inputFile = txtInputFilePath_GetAudio.Text;
            string outputFolder = txtOutputFilePath_GetAudio.Text;

            string outputFileName = Path.GetFileNameWithoutExtension(inputFile);
            if (txtInputFilePath_GetAudio.Text == "" || txtOutputFilePath_GetAudio.Text == "")
            {
                MessageBox.Show("phải chọn input và output folder để thực thi tác vụ này !");
                return;
            }

            else
            {
                if (outputFolder.Contains(" ") || inputFile.Contains(" ")) 
                {
                    MessageBox.Show("Tên file không được phép chứa khoảng trắng");
                    return;
                }

                string command = $"-i {inputFile}  -vn -ab 320 {outputFolder}.mp3";
                try
                {
                    WaitFormFunc wf = new WaitFormFunc();
                    wf.Show(this);
                    RunCMD.Instance.runCMD(command);
                    wf.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }



            List<string> temp = new List<string>();
            temp.Add(txtInputFilePath_GetAudio.Text);
            temp.Add(txtOutputFilePath_GetAudio.Text + outputFileName + ".mp3");
            this.listInOut.Add(temp);
        }

        private void btnCancleForm_GetAudiof_Click(object sender, EventArgs e)
        {
            this.Close();
            //string command = $"-muxers";
            //RunCMD.Instance.runCMD(command);
        }

        private void txtInputFilePath_GetAudio_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
