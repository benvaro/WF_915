using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_Controls
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lbSeason.Text = lbNumber.Text = "";
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            this.Text = String.Format("Selected: {0} - {1}", e.Start.ToShortDateString(), e.End.ToShortDateString());
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
          var month = monthCalendar1.SelectionStart.Month;
            if (month >= 9 && month <= 11)
            {
                lbSeason.Text = "Autumn";
            }
            else if (month >= 3 && month <= 5)
            {
                lbSeason.Text = "Spring";
            }
            else if (month >= 6 && month <= 8)
            {
                lbSeason.Text = "Summer";
            }
            else
                lbSeason.Text = "Winter";
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            this.Text = dateTimePicker1.Value.ToLongDateString();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            lbNumber.Text = "Value: " + (sender as NumericUpDown).Value;
        }
    }
}
