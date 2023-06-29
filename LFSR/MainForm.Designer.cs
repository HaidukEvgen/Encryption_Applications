
namespace TI2
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
            saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            initialStateTB = new System.Windows.Forms.TextBox();
            encipherButton = new System.Windows.Forms.Button();
            plaintextRTB = new System.Windows.Forms.RichTextBox();
            ciphertextRTB = new System.Windows.Forms.RichTextBox();
            openFileDialog = new System.Windows.Forms.OpenFileDialog();
            keyRTB = new System.Windows.Forms.RichTextBox();
            saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Dock = System.Windows.Forms.DockStyle.Top;
            label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(0, 31);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(1130, 34);
            label1.TabIndex = 0;
            label1.Text = "LFSR-based Stream Cipher encryption system";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            menuStrip1.Size = new System.Drawing.Size(1130, 31);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { openToolStripMenuItem, saveToolStripMenuItem });
            fileToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new System.Drawing.Size(55, 27);
            fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O;
            openToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
            openToolStripMenuItem.Text = "Open";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Enabled = false;
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S;
            saveToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
            saveToolStripMenuItem.Text = "Close";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(199, 349);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(163, 34);
            label2.TabIndex = 2;
            label2.Text = "Initial state";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(758, 349);
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
            label4.Location = new System.Drawing.Point(340, 87);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(402, 30);
            label4.TabIndex = 4;
            label4.Text = "Inital state of the register (36 bits)";
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label5.Location = new System.Drawing.Point(513, 162);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(56, 30);
            label5.TabIndex = 5;
            label5.Text = "Key";
            label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // initialStateTB
            // 
            initialStateTB.BackColor = System.Drawing.SystemColors.Window;
            initialStateTB.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            initialStateTB.ForeColor = System.Drawing.Color.Green;
            initialStateTB.Location = new System.Drawing.Point(273, 120);
            initialStateTB.MaxLength = 36;
            initialStateTB.Name = "initialStateTB";
            initialStateTB.Size = new System.Drawing.Size(536, 32);
            initialStateTB.TabIndex = 6;
            initialStateTB.Text = "101101011010100111010101010010101101";
            initialStateTB.TextChanged += initialStateTB_TextChanged;
            // 
            // encipherButton
            // 
            encipherButton.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            encipherButton.Location = new System.Drawing.Point(379, 696);
            encipherButton.Name = "encipherButton";
            encipherButton.Size = new System.Drawing.Size(383, 48);
            encipherButton.TabIndex = 10;
            encipherButton.Text = "Encipher/Decipher";
            encipherButton.UseVisualStyleBackColor = true;
            encipherButton.Click += encipherButton_Click;
            // 
            // plaintextRTB
            // 
            plaintextRTB.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            plaintextRTB.Location = new System.Drawing.Point(12, 386);
            plaintextRTB.Name = "plaintextRTB";
            plaintextRTB.Size = new System.Drawing.Size(536, 304);
            plaintextRTB.TabIndex = 13;
            plaintextRTB.Text = "";
            // 
            // ciphertextRTB
            // 
            ciphertextRTB.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            ciphertextRTB.Location = new System.Drawing.Point(582, 386);
            ciphertextRTB.Name = "ciphertextRTB";
            ciphertextRTB.Size = new System.Drawing.Size(536, 304);
            ciphertextRTB.TabIndex = 14;
            ciphertextRTB.Text = "";
            // 
            // keyRTB
            // 
            keyRTB.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            keyRTB.Location = new System.Drawing.Point(273, 195);
            keyRTB.Name = "keyRTB";
            keyRTB.ReadOnly = true;
            keyRTB.Size = new System.Drawing.Size(536, 151);
            keyRTB.TabIndex = 15;
            keyRTB.Text = "";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1130, 755);
            Controls.Add(keyRTB);
            Controls.Add(ciphertextRTB);
            Controls.Add(plaintextRTB);
            Controls.Add(encipherButton);
            Controls.Add(initialStateTB);
            Controls.Add(label5);
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
            Text = "LFSR";
            Load += MainForm_Load;
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox initialStateTB;
        private System.Windows.Forms.Button encipherButton;
        private System.Windows.Forms.RichTextBox plaintextRTB;
        private System.Windows.Forms.RichTextBox ciphertextRTB;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.RichTextBox keyRTB;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}

