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
            InitializeModeComboBox();
            
            refreshNumericLength();
        }

        private void InitializeModeComboBox()
        {                     
            comboBoxMode.DataSource = Enum.GetValues(typeof(GenerationType));
            
            if (!Enum.IsDefined(typeof(GenerationType), Properties.Settings.Default.Mode))
                Properties.Settings.Default.Mode = GenerationType.Ascii.ToString();

            comboBoxMode.SelectedItem = Enum.Parse(typeof(GenerationType), Properties.Settings.Default.Mode);                                
        }

        private IPasswordGenerator getGenerator() {
            GenerationType mode = (GenerationType)comboBoxMode.SelectedItem;
            switch (mode)
            {
                case GenerationType.Ascii:
                    return new Generators.AsciiGenerator();                    
                case GenerationType.Dictionary:
                    return new Generators.DictionaryGenerator();                    
                case GenerationType.Hex:
                    return new Generators.HexGenerator();                    
                default:
                    throw new ArgumentException("Invalid mode set!");
            } 
        }

        private void refreshNumericLength()
        {
            numericLength.Value = getGenerator().getCachedLength();         
        }


        private void buttonGenerate_Click(object sender, EventArgs e)
        {            
            try
            {
                Properties.Settings.Default.Mode = comboBoxMode.SelectedValue.ToString();
                textboxPassword.Text = getGenerator().generatePassword((short)numericLength.Value);                
                Properties.Settings.Default.Save();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);                
            }
            
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
            //comboBoxMode_SelectedIndexChanged(this, null);
        }

        private void comboBoxMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            refreshNumericLength();
        }
    }
}
