using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoEditor
{
    public partial class VideoEditorUC : UserControl
    {
        public VideoEditorUC()
        {
            InitializeComponent();
        }

        public string input;
        public string output;
        

        // lấy audio tuef video
        private void btnGetAudioFormVideoOP_Click(object sender, EventArgs e)
        {
            fGetAudio f = new fGetAudio();
            //fmain.instance.Hide();
            f.ShowDialog();
            for (int i = 0; i < f.listInOut.Count; i++)
            {
                dgvShowProgress.Rows.Add(f.listInOut[i][0], f.listInOut[i][1], "Geting audio");
            }
            //fmain.instance.Show();
        }

        // cắt video
        private void btnVideoAudioCuttingOP_Click(object sender, EventArgs e)
        {
            fVideoAudioCutting f = new fVideoAudioCutting();
            //fmain.instance.Hide();
            f.ShowDialog();

            for (int i = 0; i < f.listInOut.Count; i++)
            {
                dgvShowProgress.Rows.Add(f.listInOut[i][0], f.listInOut[i][1], "Spliting video");
            }

            //fmain.instance.Show();
        }

        // convert định dạng video audio, ảnh
        private void btnConvertVideoAudioOP_Click(object sender, EventArgs e)
        {
            fVideoConvertor f = new fVideoConvertor();
            //fmain.instance.Hide();
            f.ShowDialog();
            for (int i = 0; i < f.listInOut.Count; i++)
            {
                dgvShowProgress.Rows.Add(f.listInOut[i][0], f.listInOut[i][1], "converting");
            }
            //fmain.instance.Show();
        }

        // reset tốc độ video
        private void btnVideoAudioSpeedControlOP_Click(object sender, EventArgs e)
        {
            fVideoSpeedControler f = new fVideoSpeedControler();
            //fmain.instance.Hide();
            f.ShowDialog();

            for(int i=0; i<f.listInOut.Count; i++)
            {
                dgvShowProgress.Rows.Add(f.listInOut[i][0], f.listInOut[i][1], "reseting speed");
            }

            //fmain.instance.Show();
        }

        // thêm sub
        private void btnAddSubForVideoOP_Click(object sender, EventArgs e)
        {
            fAddSubForVideo f = new fAddSubForVideo();
            //fmain.instance.Hide();
            f.ShowDialog();

            for (int i = 0; i < f.listInOut.Count; i++)
            {
                dgvShowProgress.Rows.Add(f.listInOut[i][0], f.listInOut[i][2], "adding subtile");
                dgvShowProgress.Rows.Add(f.listInOut[i][1]);
            }
            //fmain.instance.Show();
        }

        //
        private void btnVideoDesignOP_Click(object sender, EventArgs e)
        {
            fVdeoEdtitor f = new fVdeoEdtitor();
            //fmain.instance.Hide();
            f.ShowDialog();
            for (int i = 0; i < f.listInOut.Count; i++)
            {
                for(int k=0; k< f.listInOut[i].Count - 1; k++)
                {
                    if (k == 0)
                    {
                        dgvShowProgress.Rows.Add(f.listInOut[i][k], f.listInOut[i][f.listInOut[i].Count - 1], "creating video");
                    }
                    else
                    {
                        dgvShowProgress.Rows.Add(f.listInOut[i][k]);
                    }
                }
            }
            //fmain.instance.Show();
        }
    }
}
