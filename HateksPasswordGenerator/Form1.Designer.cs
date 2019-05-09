namespace HateksPasswordGenerator
{
    partial class Form1
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
            this.btnExcell = new System.Windows.Forms.Button();
            this.btnGenratePassword = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbUpper = new System.Windows.Forms.CheckBox();
            this.cbLower = new System.Windows.Forms.CheckBox();
            this.cbSpecial = new System.Windows.Forms.CheckBox();
            this.cbNumeric = new System.Windows.Forms.CheckBox();
            this.npupper = new System.Windows.Forms.NumericUpDown();
            this.nplower = new System.Windows.Forms.NumericUpDown();
            this.npspecial = new System.Windows.Forms.NumericUpDown();
            this.npnumeric = new System.Windows.Forms.NumericUpDown();
            this.btnSaveHere = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbRandom = new System.Windows.Forms.CheckBox();
            this.npRandom = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.npRow = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.npupper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nplower)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.npspecial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.npnumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.npRandom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.npRow)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExcell
            // 
            this.btnExcell.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnExcell.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnExcell.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnExcell.Location = new System.Drawing.Point(96, 21);
            this.btnExcell.Name = "btnExcell";
            this.btnExcell.Size = new System.Drawing.Size(122, 30);
            this.btnExcell.TabIndex = 0;
            this.btnExcell.Text = "Exceli Bul";
            this.btnExcell.UseVisualStyleBackColor = false;
            this.btnExcell.Click += new System.EventHandler(this.btnExcell_Click);
            // 
            // btnGenratePassword
            // 
            this.btnGenratePassword.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnGenratePassword.Location = new System.Drawing.Point(96, 151);
            this.btnGenratePassword.Name = "btnGenratePassword";
            this.btnGenratePassword.Size = new System.Drawing.Size(122, 30);
            this.btnGenratePassword.TabIndex = 1;
            this.btnGenratePassword.Text = "Oluştur ve Kaydet";
            this.btnGenratePassword.UseVisualStyleBackColor = false;
            this.btnGenratePassword.Click += new System.EventHandler(this.btnGenratePassword_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 2;
            // 
            // cbUpper
            // 
            this.cbUpper.AutoSize = true;
            this.cbUpper.Location = new System.Drawing.Point(269, 21);
            this.cbUpper.Name = "cbUpper";
            this.cbUpper.Size = new System.Drawing.Size(79, 17);
            this.cbUpper.TabIndex = 3;
            this.cbUpper.Text = "Büyük Harf";
            this.cbUpper.UseVisualStyleBackColor = true;
            // 
            // cbLower
            // 
            this.cbLower.AutoSize = true;
            this.cbLower.Location = new System.Drawing.Point(269, 98);
            this.cbLower.Name = "cbLower";
            this.cbLower.Size = new System.Drawing.Size(80, 17);
            this.cbLower.TabIndex = 4;
            this.cbLower.Text = "Küçük Harf";
            this.cbLower.UseVisualStyleBackColor = true;
            // 
            // cbSpecial
            // 
            this.cbSpecial.AutoSize = true;
            this.cbSpecial.Location = new System.Drawing.Point(269, 59);
            this.cbSpecial.Name = "cbSpecial";
            this.cbSpecial.Size = new System.Drawing.Size(90, 17);
            this.cbSpecial.TabIndex = 5;
            this.cbSpecial.Text = "Özel Karakter";
            this.cbSpecial.UseVisualStyleBackColor = true;
            // 
            // cbNumeric
            // 
            this.cbNumeric.AutoSize = true;
            this.cbNumeric.Location = new System.Drawing.Point(269, 135);
            this.cbNumeric.Name = "cbNumeric";
            this.cbNumeric.Size = new System.Drawing.Size(60, 17);
            this.cbNumeric.TabIndex = 6;
            this.cbNumeric.Text = "Rakam";
            this.cbNumeric.UseVisualStyleBackColor = true;
            // 
            // npupper
            // 
            this.npupper.Location = new System.Drawing.Point(400, 21);
            this.npupper.Name = "npupper";
            this.npupper.Size = new System.Drawing.Size(120, 20);
            this.npupper.TabIndex = 7;
            this.npupper.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nplower
            // 
            this.nplower.Location = new System.Drawing.Point(400, 98);
            this.nplower.Name = "nplower";
            this.nplower.Size = new System.Drawing.Size(120, 20);
            this.nplower.TabIndex = 8;
            this.nplower.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // npspecial
            // 
            this.npspecial.Location = new System.Drawing.Point(400, 58);
            this.npspecial.Name = "npspecial";
            this.npspecial.Size = new System.Drawing.Size(120, 20);
            this.npspecial.TabIndex = 9;
            this.npspecial.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // npnumeric
            // 
            this.npnumeric.Location = new System.Drawing.Point(400, 135);
            this.npnumeric.Name = "npnumeric";
            this.npnumeric.Size = new System.Drawing.Size(120, 20);
            this.npnumeric.TabIndex = 10;
            this.npnumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnSaveHere
            // 
            this.btnSaveHere.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnSaveHere.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnSaveHere.Location = new System.Drawing.Point(96, 82);
            this.btnSaveHere.Name = "btnSaveHere";
            this.btnSaveHere.Size = new System.Drawing.Size(122, 30);
            this.btnSaveHere.TabIndex = 11;
            this.btnSaveHere.Text = "Şuraya Kaydet";
            this.btnSaveHere.UseVisualStyleBackColor = false;
            this.btnSaveHere.Click += new System.EventHandler(this.btnSaveHere_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(23, 21);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(5);
            this.label2.Size = new System.Drawing.Size(54, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "1. Adım";
            // 
            // cbRandom
            // 
            this.cbRandom.AutoSize = true;
            this.cbRandom.Location = new System.Drawing.Point(269, 174);
            this.cbRandom.Name = "cbRandom";
            this.cbRandom.Size = new System.Drawing.Size(125, 17);
            this.cbRandom.TabIndex = 15;
            this.cbRandom.Text = "Tamamiyen Rastgele";
            this.cbRandom.UseVisualStyleBackColor = true;
            this.cbRandom.CheckedChanged += new System.EventHandler(this.cbRandom_CheckedChanged);
            // 
            // npRandom
            // 
            this.npRandom.Location = new System.Drawing.Point(400, 173);
            this.npRandom.Name = "npRandom";
            this.npRandom.Size = new System.Drawing.Size(120, 20);
            this.npRandom.TabIndex = 16;
            this.npRandom.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(23, 82);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(5);
            this.label3.Size = new System.Drawing.Size(54, 25);
            this.label3.TabIndex = 17;
            this.label3.Text = "2. Adım";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(23, 151);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(5);
            this.label4.Size = new System.Drawing.Size(54, 25);
            this.label4.TabIndex = 18;
            this.label4.Text = "3. Adım";
            // 
            // npRow
            // 
            this.npRow.Location = new System.Drawing.Point(400, 213);
            this.npRow.Name = "npRow";
            this.npRow.Size = new System.Drawing.Size(120, 20);
            this.npRow.TabIndex = 20;
            this.npRow.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(266, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Şu Kolona Şifreleri Yazdır";
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(96, 208);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(122, 20);
            this.txtFileName.TabIndex = 22;
            this.txtFileName.Text = "GeneratedPassword";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(23, 208);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(5);
            this.label6.Size = new System.Drawing.Size(67, 25);
            this.label6.TabIndex = 23;
            this.label6.Text = "Dosya Adı";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 257);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.npRow);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.npRandom);
            this.Controls.Add(this.cbRandom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSaveHere);
            this.Controls.Add(this.npnumeric);
            this.Controls.Add(this.npspecial);
            this.Controls.Add(this.nplower);
            this.Controls.Add(this.npupper);
            this.Controls.Add(this.cbNumeric);
            this.Controls.Add(this.cbSpecial);
            this.Controls.Add(this.cbLower);
            this.Controls.Add(this.cbUpper);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGenratePassword);
            this.Controls.Add(this.btnExcell);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hateks Password Generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.npupper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nplower)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.npspecial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.npnumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.npRandom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.npRow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExcell;
        private System.Windows.Forms.Button btnGenratePassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbUpper;
        private System.Windows.Forms.CheckBox cbLower;
        private System.Windows.Forms.CheckBox cbSpecial;
        private System.Windows.Forms.CheckBox cbNumeric;
        private System.Windows.Forms.NumericUpDown npupper;
        private System.Windows.Forms.NumericUpDown nplower;
        private System.Windows.Forms.NumericUpDown npspecial;
        private System.Windows.Forms.NumericUpDown npnumeric;
        private System.Windows.Forms.Button btnSaveHere;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbRandom;
        private System.Windows.Forms.NumericUpDown npRandom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown npRow;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Label label6;
    }
}

