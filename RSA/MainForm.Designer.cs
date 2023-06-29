
namespace RSA
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new System.Windows.Forms.Label();
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            открытьЗашифрованныйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            saveRegularFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            pTB = new System.Windows.Forms.TextBox();
            encipherButton = new System.Windows.Forms.Button();
            plaintextRTB = new System.Windows.Forms.RichTextBox();
            ciphertextRTB = new System.Windows.Forms.RichTextBox();
            openFileDialog = new System.Windows.Forms.OpenFileDialog();
            saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            qTB = new System.Windows.Forms.TextBox();
            label6 = new System.Windows.Forms.Label();
            closekeyTB = new System.Windows.Forms.TextBox();
            label7 = new System.Windows.Forms.Label();
            openkeyTB = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            decipherButton = new System.Windows.Forms.Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Dock = System.Windows.Forms.DockStyle.Top;
            label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(0, 31);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(1161, 34);
            label1.TabIndex = 0;
            label1.Text = "RSA Public Key Cryptosystem";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            menuStrip1.Size = new System.Drawing.Size(1161, 31);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { openToolStripMenuItem, открытьЗашифрованныйToolStripMenuItem, saveToolStripMenuItem, saveRegularFileToolStripMenuItem });
            fileToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new System.Drawing.Size(55, 27);
            fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new System.Drawing.Size(292, 28);
            openToolStripMenuItem.Text = "Open regular file";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // открытьЗашифрованныйToolStripMenuItem
            // 
            открытьЗашифрованныйToolStripMenuItem.Name = "открытьЗашифрованныйToolStripMenuItem";
            открытьЗашифрованныйToolStripMenuItem.Size = new System.Drawing.Size(292, 28);
            открытьЗашифрованныйToolStripMenuItem.Text = "Open encrypted file";
            открытьЗашифрованныйToolStripMenuItem.Click += openEncryptedFileToolStripMenuItem_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Enabled = false;
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new System.Drawing.Size(292, 28);
            saveToolStripMenuItem.Text = "Save encrypted file";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // saveRegularFileToolStripMenuItem
            // 
            saveRegularFileToolStripMenuItem.Enabled = false;
            saveRegularFileToolStripMenuItem.Name = "saveRegularFileToolStripMenuItem";
            saveRegularFileToolStripMenuItem.Size = new System.Drawing.Size(292, 28);
            saveRegularFileToolStripMenuItem.Text = "Save regular file";
            saveRegularFileToolStripMenuItem.Click += SaveRegularFileToolStripMenuItemClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(228, 253);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(135, 34);
            label2.TabIndex = 2;
            label2.Text = "Initial file";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(775, 253);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(185, 34);
            label3.TabIndex = 3;
            label3.Text = "Resulting file";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(29, 82);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(353, 30);
            label4.TabIndex = 4;
            label4.Text = "Parameter p (prime number)";
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pTB
            // 
            pTB.BackColor = System.Drawing.SystemColors.Window;
            pTB.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            pTB.ForeColor = System.Drawing.Color.Black;
            pTB.Location = new System.Drawing.Point(22, 132);
            pTB.MaxLength = 36;
            pTB.Name = "pTB";
            pTB.Size = new System.Drawing.Size(367, 32);
            pTB.TabIndex = 0;
            pTB.Text = "199";
            // 
            // encipherButton
            // 
            encipherButton.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            encipherButton.Location = new System.Drawing.Point(104, 600);
            encipherButton.Name = "encipherButton";
            encipherButton.Size = new System.Drawing.Size(383, 48);
            encipherButton.TabIndex = 10;
            encipherButton.Text = "Encipher";
            encipherButton.UseVisualStyleBackColor = true;
            encipherButton.Click += encipherButton_Click;
            // 
            // plaintextRTB
            // 
            plaintextRTB.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            plaintextRTB.Location = new System.Drawing.Point(27, 290);
            plaintextRTB.Name = "plaintextRTB";
            plaintextRTB.ReadOnly = true;
            plaintextRTB.Size = new System.Drawing.Size(536, 304);
            plaintextRTB.TabIndex = 13;
            plaintextRTB.Text = "";
            // 
            // ciphertextRTB
            // 
            ciphertextRTB.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            ciphertextRTB.Location = new System.Drawing.Point(599, 290);
            ciphertextRTB.Name = "ciphertextRTB";
            ciphertextRTB.ReadOnly = true;
            ciphertextRTB.Size = new System.Drawing.Size(536, 304);
            ciphertextRTB.TabIndex = 14;
            ciphertextRTB.Text = "";
            // 
            // qTB
            // 
            qTB.BackColor = System.Drawing.SystemColors.Window;
            qTB.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            qTB.ForeColor = System.Drawing.Color.Black;
            qTB.Location = new System.Drawing.Point(395, 132);
            qTB.MaxLength = 36;
            qTB.Name = "qTB";
            qTB.Size = new System.Drawing.Size(367, 32);
            qTB.TabIndex = 1;
            qTB.Text = "197";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label6.Location = new System.Drawing.Point(402, 82);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(353, 30);
            label6.TabIndex = 16;
            label6.Text = "Parameter q (prime number)";
            label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // closekeyTB
            // 
            closekeyTB.BackColor = System.Drawing.SystemColors.Window;
            closekeyTB.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            closekeyTB.ForeColor = System.Drawing.Color.Black;
            closekeyTB.Location = new System.Drawing.Point(768, 132);
            closekeyTB.MaxLength = 36;
            closekeyTB.Name = "closekeyTB";
            closekeyTB.Size = new System.Drawing.Size(367, 32);
            closekeyTB.TabIndex = 2;
            closekeyTB.Text = "19";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label7.Location = new System.Drawing.Point(863, 82);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(176, 30);
            label7.TabIndex = 18;
            label7.Text = "Secret key (d)";
            label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // openkeyTB
            // 
            openkeyTB.BackColor = System.Drawing.SystemColors.Window;
            openkeyTB.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            openkeyTB.ForeColor = System.Drawing.Color.Black;
            openkeyTB.Location = new System.Drawing.Point(398, 217);
            openkeyTB.MaxLength = 36;
            openkeyTB.Name = "openkeyTB";
            openkeyTB.Size = new System.Drawing.Size(367, 32);
            openkeyTB.TabIndex = 22;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label5.Location = new System.Drawing.Point(511, 167);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(140, 30);
            label5.TabIndex = 21;
            label5.Text = "Publlic key";
            label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // decipherButton
            // 
            decipherButton.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            decipherButton.Location = new System.Drawing.Point(676, 600);
            decipherButton.Name = "decipherButton";
            decipherButton.Size = new System.Drawing.Size(383, 48);
            decipherButton.TabIndex = 23;
            decipherButton.Text = "Decipher";
            decipherButton.UseVisualStyleBackColor = true;
            decipherButton.Click += decipherButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1161, 658);
            Controls.Add(decipherButton);
            Controls.Add(openkeyTB);
            Controls.Add(label5);
            Controls.Add(closekeyTB);
            Controls.Add(label7);
            Controls.Add(qTB);
            Controls.Add(label6);
            Controls.Add(ciphertextRTB);
            Controls.Add(plaintextRTB);
            Controls.Add(encipherButton);
            Controls.Add(pTB);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "RSA Public Key Cryptosystem";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox pTB;
        private System.Windows.Forms.Button encipherButton;
        private System.Windows.Forms.RichTextBox plaintextRTB;
        private System.Windows.Forms.RichTextBox ciphertextRTB;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.TextBox qTB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox closekeyTB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox openkeyTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button decipherButton;
        private System.Windows.Forms.ToolStripMenuItem открытьЗашифрованныйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveRegularFileToolStripMenuItem;
    }
}

