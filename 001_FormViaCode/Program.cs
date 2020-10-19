using System;
using System.Drawing;
using System.Windows.Forms;

namespace _001_FormViaCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Form form = new Form();

            form.Text = "Window 1.0";
            form.Size = new Size(300, 250);
            form.BackColor = Color.AliceBlue;
            form.Location = new Point(0, 0);
            form.StartPosition = FormStartPosition.CenterScreen;

            Button btn = new Button();
            btn.Text = "Click me!";
            btn.Size = new Size(100, 40);
            btn.BackColor = Color.Aqua;
            btn.Font = new Font("Comic Sans MS", 14, FontStyle.Bold | FontStyle.Underline | FontStyle.Italic);
            btn.Location = new Point((form.ClientSize.Width - btn.ClientSize.Width) / 2, (form.ClientSize.Height - btn.ClientSize.Height) / 2);

            btn.Click += Btn_Click;

            form.MouseDoubleClick += Form_DoubleClick;

            form.Controls.Add(btn);

            form.ShowDialog();
        }

        private static void Form_DoubleClick(object sender, MouseEventArgs e)
        {
            Form temp = sender as Form;

            switch (e.Button)
            {
                case MouseButtons.Left:
                    temp.Text = "Left btn clicked  " + e.Location;
                    break;
                case MouseButtons.Right:
                    temp.Text = "Right btn clicked " + e.Location;
                    break;
                case MouseButtons.Middle:
                    temp.Text = "Middle btn clicked" + e.Location;
                    break;
            }
        }

        private static void Btn_Click(object sender, EventArgs e)
        {
            (sender as Button).Text = "Done! :)";
            (sender as Button).Parent.BackColor = Color.FromArgb(200, 134, 18);
        }
    }
}
