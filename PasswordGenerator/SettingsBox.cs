using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace PasswordGenerator
{
    public partial class SettingsBox : Form
    {
        public SettingsBox()
        {
            InitializeComponent();
            LoadFirstWords();
            textBoxFilePath.Text = Properties.Settings.Default.Dictionary;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadFirstWords()
        {
            FileStream stream;
            try
            {
                stream = File.OpenRead(Properties.Settings.Default.Dictionary);
            }
            catch (Exception)
            {
                labelFirstWords.Text = "No dictionary selected";
                return;
            }
            
            StreamReader reader = new StreamReader(stream);
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < 7 && reader.Peek() > 0; i++)
            {                
                String word = reader.ReadLine();
                if (word.Length < 2)
                {
                    i--;
                    continue;
                }
                char cap = Char.ToUpper(word[0]);
                builder.Append(cap).Append(word.Substring(1)).Append(", ");
            }

            builder.Remove(builder.Length - 2, 2);
            builder.Append("...");
            labelFirstWords.Text = builder.ToString();
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = false;
            dialog.Filter = "Text-files|*.txt";
            dialog.ShowDialog(this);

            Properties.Settings.Default.Dictionary = dialog.FileName;
            textBoxFilePath.Text = Properties.Settings.Default.Dictionary;
            Properties.Settings.Default.Save();
            LoadFirstWords();
        }

    }
}
