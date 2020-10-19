using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _00_Forms_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
           DialogResult res = MessageBox.Show("Hello, window", "First window", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Asterisk);
            switch (res)
            {   
                case DialogResult.Cancel:
                    Console.WriteLine("Cancel clicked");
                    break;
                case DialogResult.Yes:
                    Console.WriteLine("Yes clicked");
                    break;
                case DialogResult.No:
                    Console.WriteLine("No clicked");
                    break;
            }
        }
    }
}
