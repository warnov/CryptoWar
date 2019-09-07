namespace CryptoRMWin
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtSS = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDecrypt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEncrypt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtText = new System.Windows.Forms.TextBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.nudMain = new System.Windows.Forms.NumericUpDown();
            this.btnAutogenerate = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudMain)).BeginInit();
            this.SuspendLayout();
            //
            // label1
            //
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Shared Secret:";
            //
            // txtSS
            //
            this.txtSS.Location = new System.Drawing.Point(86, 10);
            this.txtSS.Name = "txtSS";
            this.txtSS.Size = new System.Drawing.Size(399, 20);
            this.txtSS.TabIndex = 1;
            //
            // label2
            //
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Decryption Test";
            //
            // txtDecrypt
            //
            this.txtDecrypt.Location = new System.Drawing.Point(85, 105);
            this.txtDecrypt.Name = "txtDecrypt";
            this.txtDecrypt.Size = new System.Drawing.Size(400, 20);
            this.txtDecrypt.TabIndex = 3;
            //
            // label3
            //
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Text to Encrypt";
            //
            // txtEncrypt
            //
            this.txtEncrypt.Location = new System.Drawing.Point(86, 75);
            this.txtEncrypt.Name = "txtEncrypt";
            this.txtEncrypt.Size = new System.Drawing.Size(399, 20);
            this.txtEncrypt.TabIndex = 6;
            //
            // label4
            //
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Encrypted Text";
            //
            // txtText
            //
            this.txtText.Location = new System.Drawing.Point(85, 40);
            this.txtText.Name = "txtText";
            this.txtText.Size = new System.Drawing.Size(400, 20);
            this.txtText.TabIndex = 8;
            //
            // btnGo
            //
            this.btnGo.Location = new System.Drawing.Point(86, 150);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(75, 23);
            this.btnGo.TabIndex = 9;
            this.btnGo.Text = "Encrypt!";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            //
            // btnDecrypt
            //
            this.btnDecrypt.Location = new System.Drawing.Point(410, 150);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(75, 23);
            this.btnDecrypt.TabIndex = 10;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            //
            // nudMain
            //
            this.nudMain.Location = new System.Drawing.Point(126, 191);
            this.nudMain.Name = "nudMain";
            this.nudMain.Size = new System.Drawing.Size(120, 20);
            this.nudMain.TabIndex = 11;
            //
            // btnAutogenerate
            //
            this.btnAutogenerate.Location = new System.Drawing.Point(263, 188);
            this.btnAutogenerate.Name = "btnAutogenerate";
            this.btnAutogenerate.Size = new System.Drawing.Size(94, 23);
            this.btnAutogenerate.TabIndex = 12;
            this.btnAutogenerate.Text = "&Autogenerate";
            this.btnAutogenerate.UseVisualStyleBackColor = true;
            this.btnAutogenerate.Click += new System.EventHandler(this.btnAutogenerate_Click);
            //
            // label5
            //
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(0, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Autogenerate Password";
            //
            // Form1
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 220);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnAutogenerate);
            this.Controls.Add(this.nudMain);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.txtText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEncrypt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDecrypt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSS);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Crypto RMWin";
            ((System.ComponentModel.ISupportInitialize)(this.nudMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion Windows Form Designer generated code

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDecrypt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEncrypt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtText;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.NumericUpDown nudMain;
        private System.Windows.Forms.Button btnAutogenerate;
        private System.Windows.Forms.Label label5;
    }
}