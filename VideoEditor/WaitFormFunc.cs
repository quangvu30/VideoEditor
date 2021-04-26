using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using VideoEditor;

namespace WaitFormExample
{
    public class WaitFormFunc
    {
        WaitForm wait;
        // khai báo muột luồng
        Thread loadthread;

        public void Show()
        {
            // nếu gội hàm show thì lồng chạy hàm loadprocess
            loadthread = new Thread(new ThreadStart(LoadingProcess));
            loadthread.Start();
        }

        public void Show(Form parent)
        {
            loadthread = new Thread(new ParameterizedThreadStart(LoadingProcess));
            // chuyền tham số vào hàm loadingpeocess
            loadthread.Start(parent);
        }

        public void Close()
        {
            if (wait != null)
            {
                string newText = "Done";
                wait.lblTitle.Invoke((MethodInvoker)delegate
                {
                    // Running on the UI thread
                    wait.lblTitle.Text = newText;
                });

                string doneImage = @"Image_Icon/checked.png";
                wait.label1.Invoke((MethodInvoker)delegate
                {
                    // Running on the UI thread
                    wait.label1.Image = Image.FromFile(doneImage);
                });

                // 1 luồng khác với luồng tạo
                wait.BeginInvoke(new System.Threading.ThreadStart(wait.CloseWaitForm));
                
                wait = null;
                loadthread = null;
            }
        }

        private void LoadingProcess()
        {
            wait = new WaitForm();
            wait.ShowDialog();
        }

        private void LoadingProcess(object parent)
        {
            Form parent1 = parent as Form;
            wait = new WaitForm(parent1);
            wait.ShowDialog();
        }
    }
}
