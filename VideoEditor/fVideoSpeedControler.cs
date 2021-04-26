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
    public partial class fVideoSpeedControler : MaterialSkin.Controls.MaterialForm
    {
        //private string input = "";
        //private string ouput = "";
        DataGridViewCell cell;
        static List<object> lsItems = new List<object>() {"0.5", "0.75", "1", "1.25", "1.5", "1.75", "2" };

        public List<List<string>> listInOut =  new List<List<string>>();

        public fVideoSpeedControler()
        {
            InitializeComponent();
            speed.Items.Clear();
            speed.Items.AddRange(lsItems.ToArray());
        }

        private void btnInput_SpeedControler_Click(object sender, EventArgs e)
        {
            string input="";
            ofdOpenInputFile_SpeedControler.Filter = "All Media Files|*.wav;*.aac;*.wma;*.wmv;*.avi;*.mpg;*.mpeg;*.m1v;*.mp2;*.mp3;*.mpa;*.mpe;*.m3u;*.mp4;*.mov;*.3g2;*.3gp2;*.3gp;*.3gpp;*.m4a;*.cda;*.aif;*.aifc;*.aiff;*.mid;*.midi;*.rmi;*.mkv;*.WAV;*.AAC;*.WMA;*.WMV;*.AVI;*.MPG;*.MPEG;*.M1V;*.MP2;*.MP3;*.MPA;*.MPE;*.M3U;*.MP4;*.MOV;*.3G2;*.3GP2;*.3GP;*.3GPP;*.M4A;*.CDA;*.AIF;*.AIFC;*.AIFF;*.MID;*.MIDI;*.RMI;*.MKV";
            if (ofdOpenInputFile_SpeedControler.ShowDialog() == DialogResult.OK)
            {
                input = ofdOpenInputFile_SpeedControler.FileName;
                if (input.Contains(" "))
                {
                    MessageBox.Show("Tên file không được phép chưa khoảng trắng !");
                    return;
                }
            }
            else
            {
                return;
            }
            dgvInOutFile_SpeedControl.Rows.Add(input, @"D:\");
            
        }

        private void btnOutput_Speedcontrol_Click(object sender, EventArgs e)
        { 
            DialogResult d = fbdOpenInpuFolder_SpeedControler.ShowDialog();
            if (d == DialogResult.OK)
            {
                cell.Value = fbdOpenInpuFolder_SpeedControler.SelectedPath;
            }
        }


        private void dgvInOutFile_SpeedControl_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex < 0)
            {
                return;
            }
            DataGridViewCell thisCell = (DataGridViewCell)dgvInOutFile_SpeedControl.Rows[e.RowIndex].Cells[e.ColumnIndex];
            cell = thisCell;
        }

        private void cbbSpeedOption_SpeedControl_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnExec_SpeedControl_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvInOutFile_SpeedControl.RowCount; i++)
            {
                string input = dgvInOutFile_SpeedControl.Rows[i].Cells[0].Value.ToString();
                string output = dgvInOutFile_SpeedControl.Rows[i].Cells[1].Value.ToString();
                string videoSpeed = string.Empty;
                try
                {
                    if(dgvInOutFile_SpeedControl.Rows[i].Cells[2].Value == null)
                    {
                        MessageBox.Show("bạn chưa chọn tốc tộ mong muốn");
                        return;
                    }
                    videoSpeed = dgvInOutFile_SpeedControl.Rows[i].Cells[2].Value.ToString();
                }
                catch(Exception ex)
                {
                    if (ex.Message.Contains("not set"))
                    {
                        MessageBox.Show("bạn chưa chọn tốc tộ mong muốn");
                    }
                }

                string newfieName = Path.GetFileNameWithoutExtension(input) + $"_x{videoSpeed}" + Path.GetExtension(input);
                if (File.Exists($"{output+newfieName}"))
                {
                    MessageBox.Show($"File kết quả {output+newfieName} đã tồn tại !");
                    continue;
                }

                if(input == "" || output == "")
                {
                    continue;
                }


                string factSpeed = string.Empty;

                List <String> temp = new List<string>();
                temp.Add(input);
                temp.Add(output+newfieName);
                listInOut.Add(temp);

                factSpeed = (1 / float.Parse(videoSpeed)).ToString();

                

                string command = $"-i {input} -filter:v \"setpts={factSpeed}*PTS\" -filter:a \"atempo={videoSpeed}\" {output}{newfieName}";
                WaitFormFunc wf = new WaitFormFunc();
                wf.Show(this);
                RunCMD.Instance.runCMD(command);
                wf.Close();
                dgvInOutFile_SpeedControl.Rows.Remove(dgvInOutFile_SpeedControl.Rows[i]);
            }
            

        }

        private void btnCancle_SpeedControl_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
