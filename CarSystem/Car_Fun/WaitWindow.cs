using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Car_Fun
{
    public partial class WaitWindow : Form
    {
        private static WaitWindow waitForm = null;
        public WaitWindow()
        {
            InitializeComponent();
        }

        public void SetMessage(string TitleText)
        {
            label1.Text = TitleText;
        }

        public static void ShowForm(string caption)
        {
            if (waitForm == null || waitForm.IsDisposed == true)
                waitForm = new WaitWindow();

            waitForm.Text = caption;
            waitForm.Refresh();
            //System.Threading.Thread.Sleep(500);
            waitForm.ShowDialog();
        }
        public static void CloseForm(string caption)
        {
            if (waitForm != null && waitForm.IsDisposed == false)
            {
                waitForm.Text = caption;
                waitForm.Refresh();
                System.Threading.Thread.Sleep(1000);
                waitForm.Dispose();
            }
        }
        public static void SetCaption(string caption)
        {
            if (waitForm != null && waitForm.IsDisposed == false)
            {
                waitForm.Text = caption;
                waitForm.Refresh();
            }
        }
    }
}
