using MaterialSkin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoEditor
{
    public partial class fmain : MaterialSkin.Controls.MaterialForm
    {
        public static fmain instance;
        MaterialSkinManager skinManager = MaterialSkinManager.Instance;
        public fmain()
        {
            InitializeComponent();
            instance = this;

            //Init skin
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Green900, MaterialSkin.Primary.BlueGrey900, MaterialSkin.Primary.Blue500, MaterialSkin.Accent.Orange700, MaterialSkin.TextShade.WHITE);

            panel1.Controls.Add(new SubCreatorUC());
        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void videoEditorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(new VideoEditorUC());
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(new SubCreatorUC());
        }
    }
}
