using System.Drawing;
using System.Windows.Forms;

namespace _04_Keyboard
{
    public partial class Form1 : Form
    {
        Icon icon = null;
        int size;

        int stepMin = 2;
        int stepMax = 10;
        int x, y;

        public Form1()
        {
            InitializeComponent();
            string path = "Bird.ico";
            icon = new Icon(path);
            size = 64;
            x = (ClientSize.Width - size) / 2;
            y = (ClientSize.Height - size) / 2;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.Control:
                    break;
                case Keys.Left:
                    x -= stepMin;
                    break;
                case Keys.Up:
                    y -= stepMin;
                    break;
                case Keys.Right:
                    x += stepMin;
                    break;
                case Keys.Down:
                    y += stepMin;
                    break;
                case Keys.A:
                    size += 10;
                    break;
                case Keys.Q:
                    size -= 10;
                    break;
            }
            this.Refresh();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawIcon(icon, new Rectangle(x, y, size, size));
        }
    }
}
