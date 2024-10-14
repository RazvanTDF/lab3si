namespace WindowsFormsApplication11
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
            this.comboBoxMAC = new System.Windows.Forms.ComboBox();
            this.buttonCompute = new System.Windows.Forms.Button();
            this.buttonVerify = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxKey = new System.Windows.Forms.TextBox();
            this.textBoxPlain = new System.Windows.Forms.TextBox();
            this.textBoxMAC = new System.Windows.Forms.TextBox();
            this.textBoxMACHEX = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonHash = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxMAC
            // 
            this.comboBoxMAC.FormattingEnabled = true;
            this.comboBoxMAC.Items.AddRange(new object[] {
            "SHA1",
            "MD5",
            "RIPEMD",
            "SHA256",
            "SHA384",
            "SHA512"});
            this.comboBoxMAC.Location = new System.Drawing.Point(54, 61);
            this.comboBoxMAC.Name = "comboBoxMAC";
            this.comboBoxMAC.Size = new System.Drawing.Size(205, 21);
            this.comboBoxMAC.TabIndex = 0;
            // 
            // buttonCompute
            // 
            this.buttonCompute.Location = new System.Drawing.Point(66, 162);
            this.buttonCompute.Name = "buttonCompute";
            this.buttonCompute.Size = new System.Drawing.Size(207, 67);
            this.buttonCompute.TabIndex = 1;
            this.buttonCompute.Text = "Compute MAC";
            this.buttonCompute.UseVisualStyleBackColor = true;
            this.buttonCompute.Click += new System.EventHandler(this.buttonCompute_Click_1);
            // 
            // buttonVerify
            // 
            this.buttonVerify.Location = new System.Drawing.Point(66, 314);
            this.buttonVerify.Name = "buttonVerify";
            this.buttonVerify.Size = new System.Drawing.Size(207, 67);
            this.buttonVerify.TabIndex = 2;
            this.buttonVerify.Text = "Verify MAC";
            this.buttonVerify.UseVisualStyleBackColor = true;
            this.buttonVerify.Click += new System.EventHandler(this.buttonVerify_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(601, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "KEY";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(482, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "ASCII";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(482, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "ASCII";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(491, 314);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "ASCII";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(491, 352);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "HEX";
            // 
            // textBoxKey
            // 
            this.textBoxKey.Location = new System.Drawing.Point(557, 81);
            this.textBoxKey.Name = "textBoxKey";
            this.textBoxKey.Size = new System.Drawing.Size(212, 20);
            this.textBoxKey.TabIndex = 8;
            // 
            // textBoxPlain
            // 
            this.textBoxPlain.Location = new System.Drawing.Point(557, 192);
            this.textBoxPlain.Name = "textBoxPlain";
            this.textBoxPlain.Size = new System.Drawing.Size(212, 20);
            this.textBoxPlain.TabIndex = 9;
            // 
            // textBoxMAC
            // 
            this.textBoxMAC.Location = new System.Drawing.Point(557, 307);
            this.textBoxMAC.Name = "textBoxMAC";
            this.textBoxMAC.Size = new System.Drawing.Size(212, 20);
            this.textBoxMAC.TabIndex = 10;
            // 
            // textBoxMACHEX
            // 
            this.textBoxMACHEX.Location = new System.Drawing.Point(557, 352);
            this.textBoxMACHEX.Name = "textBoxMACHEX";
            this.textBoxMACHEX.Size = new System.Drawing.Size(212, 20);
            this.textBoxMACHEX.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(554, 276);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "mac";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(554, 162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Plain Text";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(554, 393);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "hash";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(557, 424);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(212, 20);
            this.textBox1.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(491, 431);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "ASCII";
            // 
            // buttonHash
            // 
            this.buttonHash.Location = new System.Drawing.Point(66, 393);
            this.buttonHash.Name = "buttonHash";
            this.buttonHash.Size = new System.Drawing.Size(207, 67);
            this.buttonHash.TabIndex = 17;
            this.buttonHash.Text = "Compute Hash";
            this.buttonHash.UseVisualStyleBackColor = true;
            this.buttonHash.Click += new System.EventHandler(this.buttonHash_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 472);
            this.Controls.Add(this.buttonHash);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxMACHEX);
            this.Controls.Add(this.textBoxMAC);
            this.Controls.Add(this.textBoxPlain);
            this.Controls.Add(this.textBoxKey);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonVerify);
            this.Controls.Add(this.buttonCompute);
            this.Controls.Add(this.comboBoxMAC);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxMAC;
        private System.Windows.Forms.Button buttonCompute;
        private System.Windows.Forms.Button buttonVerify;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxKey;
        private System.Windows.Forms.TextBox textBoxPlain;
        private System.Windows.Forms.TextBox textBoxMAC;
        private System.Windows.Forms.TextBox textBoxMACHEX;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonHash;
    }
}

