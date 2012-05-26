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
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            textboxPassword.Text = Password.GeneratePassword((int) numericLength.Value); 
        }

        private void buttonCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textboxPassword.Text);

        }
    }
}
