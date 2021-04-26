using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoEditor
{
    public partial class WaitForm : Form
    {
        public WaitForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;
            lblTitle.Text = "Please wait...";
            label1.Image = Image.FromFile(@"Image_Icon/126.gif");
        }

        public WaitForm(Form parent)
        {
            InitializeComponent();
            lblTitle.Text = "Please wait...";
            label1.Image = Image.FromFile(@"Image_Icon/126.gif");
            if (parent != null)
            {
                this.StartPosition = FormStartPosition.Manual;
                this.Location = new Point(parent.Location.X + parent.Width / 2 - this.Width / 2,
                    parent.Location.Y + parent.Height / 2 - this.Height / 2);
            }
            else
                this.StartPosition = FormStartPosition.CenterParent;
        }

        public void CloseWaitForm()
        {
            if (label1.Image != null)
            {
                label1.Image.Dispose();
            }
            this.DialogResult = DialogResult.OK;
            Thread.Sleep(1000);
            this.Close();
        }
    }
}
