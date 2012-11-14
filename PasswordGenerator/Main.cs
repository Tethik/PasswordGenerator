using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PasswordLib;
using System.IO;

namespace PasswordGenerator
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

            checkBoxDictionary.Checked = Properties.Settings.Default.InDictionaryMode;
            refreshNumericLength();
        }

        private void refreshNumericLength()
        {            
            if (!checkBoxDictionary.Checked)            
                numericLength.Value = Properties.Settings.Default.Length;
            else
                numericLength.Value = Properties.Settings.Default.DictionaryLength;
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            
            if (checkBoxDictionary.Checked)
            {
                try
                {
                    textboxPassword.Text = Password.GenerateDictionaryPassword(Properties.Settings.Default.Dictionary, (int)numericLength.Value);
                    Properties.Settings.Default.DictionaryLength = (short)numericLength.Value;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Dictionary file could not be opened!");
                    checkBoxDictionary.Checked = false;
                    Properties.Settings.Default.InDictionaryMode = checkBoxDictionary.Checked;
                    Properties.Settings.Default.Save();
                    return;
                }
            }
            else
            {
                textboxPassword.Text = Password.GeneratePassword((int)numericLength.Value);
                Properties.Settings.Default.Length = (short)numericLength.Value;
            }            
            Properties.Settings.Default.Save();
        }

        private void buttonCopy_Click(object sender, EventArgs e)
        {
            if(textboxPassword.Text.Length > 0)
                Clipboard.SetText(textboxPassword.Text);
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingsBox window = new SettingsBox();
            window.ShowDialog(this);
            checkBoxDictionary_CheckedChanged(this, null);
        }

        private void checkBoxDictionary_CheckedChanged(object sender, EventArgs e)
        {
            refreshNumericLength();
            Properties.Settings.Default.InDictionaryMode = checkBoxDictionary.Checked;
            Properties.Settings.Default.Save();
            if (!checkBoxDictionary.Checked)           
                return;
            
            // See if dictionary is set.
            if (Properties.Settings.Default.Dictionary == null || Properties.Settings.Default.Dictionary == "")
            {
                MessageBox.Show("Dictionary not set. You can set the dictionary under Settings");
                checkBoxDictionary.Checked = false;
                return;
            }

            if (!File.Exists(Properties.Settings.Default.Dictionary))
            {
                MessageBox.Show("Dictionary does not exist!");
                checkBoxDictionary.Checked = false;
                return;
            }            
        }
    }
}
