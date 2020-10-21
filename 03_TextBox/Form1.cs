using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace _03_TextBox
{
    public partial class Form1 : Form
    {
        Dictionary<string, string> accounts = new Dictionary<string, string>();
        public Form1()
        {
            InitializeComponent();
            this.Height = 200;
        }

        private void tbPassword_Enter(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(tbLogin.Text))
                tbLogin.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            accounts["admin"] = "admin";
            accounts["user"] = "user";
        }

        private void tbPassword_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(tbPassword.Text))
            {
                MessageBox.Show("Password cant be empty");
                tbPassword.Focus();
            }
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (!accounts.ContainsKey(tbLogin.Text) || accounts[tbLogin.Text] != tbPassword.Text)
            {
                MessageBox.Show("Error login");
                Environment.Exit(0);
            }
            this.Height = 600;
        }

        private void tbMessage_TextChanged(object sender, EventArgs e)
        {
            var lines = tbMessage.Lines.Length;
            var symbols = tbMessage.Text.Length;
            var selectedStart = tbMessage.SelectionStart;
            var selectedText = tbMessage.SelectedText;

            tbResult.Text = selectedText;

            lbStat.Text = $"Lines: {lines}\nSymbols: {symbols}\n" +
                $"SelectedIndex: {selectedStart}";
        }

        private void tbMessage_MouseCaptureChanged(object sender, EventArgs e)
        {
            tbMessage_TextChanged(null, null);
        }

        private void tbMessage_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.A)
                tbMessage_TextChanged(null, null);
        }

        private void tbMessage_MouseMove(object sender, MouseEventArgs e)
        {
            this.Text = "Location: " + e.Location;
        }

        private void tbMessage_MouseEnter(object sender, EventArgs e)
        {
            (sender as TextBox).BackColor = Color.Olive;
        }

        private void tbMessage_MouseHover(object sender, EventArgs e)
        {
            (sender as TextBox).BackColor = Color.LightBlue;
        }
    }
}
