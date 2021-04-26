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
    public partial class fVideoConvertor : MaterialSkin.Controls.MaterialForm
    {
        public List<List<string>> listInOut = new List<List<string>>();
        public fVideoConvertor()
        {
            InitializeComponent();
        }

        private void btnVideoInput_Convertor_Click(object sender, EventArgs e)
        {
            btnVideoInput_Convertor.BackColor = Color.Green;
            btnAudioInput_Convertor.BackColor = Color.White;
            btnImageInput_Convertor.BackColor = Color.White;

            List<object> ls= new List<object>(){ "mp4", "mov", "avi", "wmv", "flv", "webm", "mkv"};
            cbbOutputFormat__Convertor.Items.Clear();
            cbbOutputFormat__Convertor.Items.AddRange(ls.ToArray());
        }

        private void btnImageInput_Convertor_Click(object sender, EventArgs e)
        {
            btnImageInput_Convertor.BackColor = Color.Green;
            btnAudioInput_Convertor.BackColor = Color.White;
            btnVideoInput_Convertor.BackColor = Color.White;

            List<object> ls = new List<object>() { "jpeg", "tiff", "png", "gif", "bmp" };
            cbbOutputFormat__Convertor.Items.Clear();
            cbbOutputFormat__Convertor.Items.AddRange(ls.ToArray());
        }

        private void btnAudioInput_Convertor_Click_1(object sender, EventArgs e)
        {
            btnAudioInput_Convertor.BackColor = Color.Green;
            btnImageInput_Convertor.BackColor = Color.White;
            btnVideoInput_Convertor.BackColor = Color.White;

            List<object> ls = new List<object>() { "wav", "aiff", "flac", "wma", "mp3", "ogg"};
            cbbOutputFormat__Convertor.Items.Clear();
            cbbOutputFormat__Convertor.Items.AddRange(ls.ToArray());
        }

        private void btnBrowseInput_Convertor_Click(object sender, EventArgs e)
        {
            // hoặc ảnh, hoặc video, hoặc audio
            DialogResult d = ofdChooseInput_Convertor.ShowDialog();
            if (d == DialogResult.OK)
            {
                if (ofdChooseInput_Convertor.FileName.Contains(" "))
                {
                    MessageBox.Show("Tên file không được phép chưa khoảng trắng !");
                    return;
                }
                txtInputFilePath_Convertor.Text = ofdChooseInput_Convertor.FileName;
            }
        }

        private void btnBrowseOutput_Convertor_Click(object sender, EventArgs e)
        {
            DialogResult d = sfdOutputFolder_Convertor.ShowDialog();
            if (d == DialogResult.OK)
            {
                if (File.Exists(sfdOutputFolder_Convertor.FileName))
                {
                    MessageBox.Show("Tên file đã tồn tại mời bạn chọn tên khác !");
                    return;
                }
                txtOutputFolderPath_Convertor.Text = sfdOutputFolder_Convertor.FileName;
            }
        }

        private void btnExec__Convertor_Click(object sender, EventArgs e)
        {
            string inputFile = txtInputFilePath_Convertor.Text;
            string outputFolder = txtOutputFolderPath_Convertor.Text;

            if (txtInputFilePath_Convertor.Text == "" || txtOutputFolderPath_Convertor.Text == "")
            {
                MessageBox.Show("phải chọn input và output folder để thực thi tác vụ này !");
                return;
            }
            else
            {
                string command = $"-i {inputFile} {outputFolder}.{cbbOutputFormat__Convertor.SelectedItem.ToString()}";
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
            temp.Add(txtInputFilePath_Convertor.Text);
            temp.Add($"{outputFolder}.{cbbOutputFormat__Convertor.SelectedItem.ToString()}");
            this.listInOut.Add(temp);
        }

        private void btnCancleForm__Convertor_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
