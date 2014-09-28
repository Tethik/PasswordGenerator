namespace PasswordGenerator
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
			this.btnGenerate = new System.Windows.Forms.Button();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.btnCopy = new System.Windows.Forms.Button();
			this.lbl1 = new System.Windows.Forms.Label();
			this.lbl2 = new System.Windows.Forms.Label();
			this.numLength = new System.Windows.Forms.NumericUpDown();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.toolStripItemSettings = new System.Windows.Forms.ToolStripMenuItem();
			this.cmbMode = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.numLength)).BeginInit();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnGenerate
			// 
			this.btnGenerate.Location = new System.Drawing.Point(278, 75);
			this.btnGenerate.Name = "btnGenerate";
			this.btnGenerate.Size = new System.Drawing.Size(77, 30);
			this.btnGenerate.TabIndex = 0;
			this.btnGenerate.Text = "Generate";
			this.btnGenerate.UseVisualStyleBackColor = true;
			this.btnGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
			// 
			// txtPassword
			// 
			this.txtPassword.Location = new System.Drawing.Point(15, 49);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.ReadOnly = true;
			this.txtPassword.Size = new System.Drawing.Size(257, 20);
			this.txtPassword.TabIndex = 1;
			// 
			// btnCopy
			// 
			this.btnCopy.Location = new System.Drawing.Point(155, 75);
			this.btnCopy.Name = "btnCopy";
			this.btnCopy.Size = new System.Drawing.Size(117, 30);
			this.btnCopy.TabIndex = 2;
			this.btnCopy.Text = "Copy to Clipboard";
			this.btnCopy.UseVisualStyleBackColor = true;
			this.btnCopy.Click += new System.EventHandler(this.buttonCopy_Click);
			// 
			// lbl1
			// 
			this.lbl1.AutoSize = true;
			this.lbl1.Location = new System.Drawing.Point(12, 33);
			this.lbl1.Name = "lbl1";
			this.lbl1.Size = new System.Drawing.Size(53, 13);
			this.lbl1.TabIndex = 4;
			this.lbl1.Text = "Password";
			// 
			// lbl2
			// 
			this.lbl2.AutoSize = true;
			this.lbl2.Location = new System.Drawing.Point(275, 33);
			this.lbl2.Name = "lbl2";
			this.lbl2.Size = new System.Drawing.Size(40, 13);
			this.lbl2.TabIndex = 5;
			this.lbl2.Text = "Length";
			// 
			// numLength
			// 
			this.numLength.Location = new System.Drawing.Point(278, 50);
			this.numLength.Name = "numLength";
			this.numLength.Size = new System.Drawing.Size(77, 20);
			this.numLength.TabIndex = 6;
			this.numLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.numLength.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripItemSettings});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(364, 24);
			this.menuStrip1.TabIndex = 8;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// toolStripItemSettings
			// 
			this.toolStripItemSettings.Name = "toolStripItemSettings";
			this.toolStripItemSettings.Size = new System.Drawing.Size(61, 20);
			this.toolStripItemSettings.Text = "Settings";
			this.toolStripItemSettings.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
			// 
			// cmbMode
			// 
			this.cmbMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbMode.FormattingEnabled = true;
			this.cmbMode.Location = new System.Drawing.Point(15, 75);
			this.cmbMode.Name = "cmbMode";
			this.cmbMode.Size = new System.Drawing.Size(121, 21);
			this.cmbMode.TabIndex = 9;
			this.cmbMode.SelectedIndexChanged += new System.EventHandler(this.comboBoxMode_SelectedIndexChanged);
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(364, 116);
			this.Controls.Add(this.cmbMode);
			this.Controls.Add(this.numLength);
			this.Controls.Add(this.lbl2);
			this.Controls.Add(this.lbl1);
			this.Controls.Add(this.btnCopy);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this.btnGenerate);
			this.Controls.Add(this.menuStrip1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Main";
			this.Text = "Password Generator";
			((System.ComponentModel.ISupportInitialize)(this.numLength)).EndInit();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.NumericUpDown numLength;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripItemSettings;
        private System.Windows.Forms.ComboBox cmbMode;
    }
}

