using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using TranslateSubtitleVideo.controller;
using WaitFormExample;

namespace VideoEditor
{
    public partial class SubCreatorUC : UserControl
    {
        public SubCreatorUC()
        {
            InitializeComponent();
        }

        private void btnBrowseInput_Click(object sender, EventArgs e)
        {
            ofdChooseInput.Filter = "MP4 File (*.mp4)|*.mp4||";
            DialogResult d = ofdChooseInput.ShowDialog();
            if(d == DialogResult.OK)
            {
                if (ofdChooseInput.FileName.Contains(" "))
                {
                    MessageBox.Show("Tên file không được phép chưa khoảng trắng !");
                    return;
                }
                txtInputFilePath.Text = ofdChooseInput.FileName;
            }
        }

        private void btnBrowseOutput_Click(object sender, EventArgs e)
        {
            sfdChooseOutput_SubAddedVideoCreator.Filter = "MP4 File (*.mp4)|*.mp4||";
            if (sfdChooseOutput_SubAddedVideoCreator.ShowDialog() == DialogResult.OK)
            {
                string filename = sfdChooseOutput_SubAddedVideoCreator.FileName;
                if (File.Exists(filename))
                {
                    MessageBox.Show("Tên file đã tồn tại, xin mời đặt tên khác !");
                    return;
                }
                txtOutputFilePath.Text = filename;
            }
        }

        private void btnFromAvailableSubOp_Click(object sender, EventArgs e)
        {
            btnFromAvailableSubOp.BackColor = Color.Green;
            btnFromAudioOp.BackColor = Color.White;
        }

        private void btnFromAudioOp_Click(object sender, EventArgs e)
        {
            btnFromAvailableSubOp.BackColor = Color.White;
            btnFromAudioOp.BackColor = Color.Green;
        }

        private void btnExe_RenderSub_Click(object sender, EventArgs e)
        {
            if(txtInputFilePath.Text == "" || txtOutputFilePath.Text == "")
            {
                MessageBox.Show("phải chọn input và output folder để thực thi tác vụ này !");
                return;
            }

            WaitFormFunc wf = new WaitFormFunc();
            wf.Show();

            VideoController.SubCreate(txtInputFilePath.Text, txtOutputFilePath.Text);
            File.Copy(@"SubTranslated.srt", sfdChooseOutput_SubAddedVideoCreator.FileName.Replace(Path.GetExtension(sfdChooseOutput_SubAddedVideoCreator.FileName), ".srt"));

            wf.Close();
        }
    }
}
