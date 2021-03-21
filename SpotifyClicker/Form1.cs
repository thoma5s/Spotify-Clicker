using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Easy;
using Memory;

namespace night_client
{

    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }


        //Left Clicker START

        private void leftclicker_Tick(object sender, EventArgs e)
        {
            try
            {
                leftclicker.Interval = 1000 / Convert.ToInt32((slider1.Value * 20).ToString("0"));
                if (guna2CustomCheckBox1.Checked == true)
                {
                    if (MouseButtons == MouseButtons.Left)
                    {
                        clickerclass.leftclick(1);
                    }
                }
            }
            catch (Exception) { }
        }

        private void guna2CustomCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (guna2CustomCheckBox1.Checked)
            {
                leftclicker.Start();
            }
            else
            {
                leftclicker.Stop();
            }
        }

        private void slider1_MouseMove(object sender, MouseEventArgs e)
        {
            cpslabel.Text = (slider1.Value * 20).ToString("0.0") + "";
        }

        //Left Clicker STOP


        private void minimise_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void hide_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void asdasd_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://youtube.com/Nightbot");
            System.Diagnostics.Process.Start("http://cheat.gq");
        }
    }
}