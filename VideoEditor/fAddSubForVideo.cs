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
using WaitFormExample;

namespace VideoEditor
{
    public partial class fAddSubForVideo : MaterialSkin.Controls.MaterialForm
    {
        public List<List<string>> listInOut = new List<List<string>>();
        public fAddSubForVideo()
        {
            InitializeComponent();
        }


        private void btnBrowseInputSubFile_AddingSub_Click(object sender, EventArgs e)
        {
            DialogResult d = ofdChooseInputSub_AddSub.ShowDialog();
            ofdChooseInputSub_AddSub.Filter = "Text files (*.srt)|*.srt||";
            if (d == DialogResult.OK)
            {
                if (ofdChooseInputSub_AddSub.FileName.Contains(" "))
                {
                    MessageBox.Show("Tên file không được phép chưa khoảng trắng !");
                    return;
                }
                txtInputSubFilePath_AddingSub.Text = ofdChooseInputSub_AddSub.FileName;
            }
        }

        private void btnBrowseInputVideo_AddingSub_Click(object sender, EventArgs e)
        {
            ofdChooseInputSub_AddSub.Filter = "MP4 File (*.mp4)|*.mp4||";
            DialogResult d = ofdChooseInputSub_AddSub.ShowDialog();
            if (d == DialogResult.OK)
            {
                if (ofdChooseInputSub_AddSub.FileName.Contains(" "))
                {
                    MessageBox.Show("Tên file không được phép chưa khoảng trắng !");
                    return;
                }
                txtInputVideoFilePath_AddingSub.Text = ofdChooseInputSub_AddSub.FileName;
            }
        }

        private void btnBrowseOutput_AddingSub_Click(object sender, EventArgs e)
        {           
            DialogResult d = fbdOutoutFolder_AddSub.ShowDialog();
            if (d == DialogResult.OK)
            {
                txtOutputFilePath_AddingSub.Text = fbdOutoutFolder_AddSub.SelectedPath;
            }
        }

        private void btnExe_AddingSub_Click(object sender, EventArgs e)
        {
            if(txtOutputFilePath_AddingSub.Text == "" || txtInputVideoFilePath_AddingSub.Text == "" || txtInputSubFilePath_AddingSub.Text == "")
            {
                MessageBox.Show("phải chọn input và output folder để thực thi tác vụ này !");
                return;
            }
            string folderOutput = txtOutputFilePath_AddingSub.Text;

            // filepath video
            string fileVideoPath = txtInputVideoFilePath_AddingSub.Text;
            FileInfo fVideoInfor = new FileInfo(fileVideoPath);
            // lấy đuôi video
            string fileVideoExtention = fVideoInfor.Extension;

            // ->
            string outputFileName = Path.GetFileNameWithoutExtension(fileVideoPath) + "_sub" + fileVideoExtention;

            // copy file sub vào bebug
            string fileSubPath = txtInputSubFilePath_AddingSub.Text;
            string fileSubName = Path.GetFileName(fileSubPath);

            if (File.Exists("Subtitles2.srt"))
            {
                File.Delete("Subtitles2.srt");
            }
            File.Copy(fileSubPath, @"Subtitles2.srt");
            //Console.WriteLine(fileSubPath + "----->" + fileSubName);

            string command = $"-i {fileVideoPath} -vf subtitles=Subtitles2.srt:force_style='Borderstyle=4,Fontsize=16,BackColour=H80000000' {folderOutput}{outputFileName}";
            if (File.Exists($"{folderOutput}{outputFileName}"))
            {
                MessageBox.Show($"đã tồn tại file {folderOutput}{outputFileName}");
                return;
            }

            WaitFormFunc wf = new WaitFormFunc();
            wf.Show(this);
            RunCMD.Instance.runCMD(command);
            wf.Close();

            List<string> temp = new List<string>();
            temp.Add(fileVideoPath);
            temp.Add(fileSubPath);
            temp.Add(folderOutput + outputFileName);
            listInOut.Add(temp);
        }

        private void txtInputSubFilePath_AddingSub_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancleForm_AddingSubf_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
