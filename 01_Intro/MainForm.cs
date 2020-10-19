using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_Intro
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
         //   timer.Enabled = true;
            // timer.Start();
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            lbInfo.Text = DateTime.Now.ToLongTimeString();
            
        }
        int count = 0;
        private void MainForm_MouseClick(object sender, MouseEventArgs e)
        {
            Button btn = new Button();
            btn.Text = "Hello " + count++ ;
            btn.Location = e.Location;
            btn.Size = new Size(100, 40);
            this.Controls.Add(btn);
        }
        int i = 0;
        private void timer_Tick(object sender, EventArgs e)
        {
            this.Text = ++i + "s";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            i = 0;
            timer.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer.Enabled = false;
        }
    }
}
