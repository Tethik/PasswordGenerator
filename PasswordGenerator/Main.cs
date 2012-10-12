using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PasswordLib;

namespace PasswordGenerator
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            numericLength.Value = Properties.Settings.Default.Length;
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            textboxPassword.Text = Password.GeneratePassword((int) numericLength.Value);
            Properties.Settings.Default.Length = (short) numericLength.Value;
            Properties.Settings.Default.Save();
        }

        private void buttonCopy_Click(object sender, EventArgs e)
        {
            if(textboxPassword.Text.Length > 0)
                Clipboard.SetText(textboxPassword.Text);
        }
    }
}
