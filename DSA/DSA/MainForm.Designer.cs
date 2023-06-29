namespace Lab4
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
            hTB = new TextBox();
            label7 = new Label();
            qTB = new TextBox();
            label6 = new Label();
            pTB = new TextBox();
            label4 = new Label();
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            открытьToolStripMenuItem = new ToolStripMenuItem();
            сохранитьПодписанныйToolStripMenuItem = new ToolStripMenuItem();
            checkSignatureToolStripMenuItem = new ToolStripMenuItem();
            kTB = new TextBox();
            label2 = new Label();
            xTB = new TextBox();
            label3 = new Label();
            plaintextRTB = new RichTextBox();
            startButton = new Button();
            label5 = new Label();
            dsTB = new TextBox();
            label8 = new Label();
            hashTB = new TextBox();
            label9 = new Label();
            openFileDialog = new OpenFileDialog();
            saveFileDialog = new SaveFileDialog();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // hTB
            // 
            hTB.BackColor = SystemColors.Window;
            hTB.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            hTB.ForeColor = Color.Black;
            hTB.Location = new Point(756, 115);
            hTB.MaxLength = 36;
            hTB.Name = "hTB";
            hTB.Size = new Size(367, 32);
            hTB.TabIndex = 26;
            hTB.Text = "2";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(816, 65);
            label7.Name = "label7";
            label7.Size = new Size(247, 30);
            label7.TabIndex = 29;
            label7.Text = "Parameter h (1, p-1)";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // qTB
            // 
            qTB.BackColor = SystemColors.Window;
            qTB.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            qTB.ForeColor = Color.Black;
            qTB.Location = new Point(383, 115);
            qTB.MaxLength = 36;
            qTB.Name = "qTB";
            qTB.Size = new Size(367, 32);
            qTB.TabIndex = 24;
            qTB.Text = "107";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(390, 65);
            label6.Name = "label6";
            label6.Size = new Size(353, 30);
            label6.TabIndex = 28;
            label6.Text = "Parameter q (prime number)";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pTB
            // 
            pTB.BackColor = SystemColors.Window;
            pTB.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            pTB.ForeColor = Color.Black;
            pTB.Location = new Point(10, 115);
            pTB.MaxLength = 36;
            pTB.Name = "pTB";
            pTB.Size = new Size(367, 32);
            pTB.TabIndex = 22;
            pTB.Text = "643";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(17, 65);
            label4.Name = "label4";
            label4.Size = new Size(353, 30);
            label4.TabIndex = 27;
            label4.Text = "Parameter p (prime number)";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(0, 31);
            label1.Name = "label1";
            label1.Size = new Size(1132, 34);
            label1.TabIndex = 23;
            label1.Text = "DSA digital signature";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, checkSignatureToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 2, 0, 2);
            menuStrip1.Size = new Size(1132, 31);
            menuStrip1.TabIndex = 25;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { открытьToolStripMenuItem, сохранитьПодписанныйToolStripMenuItem });
            fileToolStripMenuItem.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(55, 27);
            fileToolStripMenuItem.Text = "File";
            // 
            // открытьToolStripMenuItem
            // 
            открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            открытьToolStripMenuItem.Size = new Size(258, 28);
            открытьToolStripMenuItem.Text = "Open regular file";
            открытьToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // сохранитьПодписанныйToolStripMenuItem
            // 
            сохранитьПодписанныйToolStripMenuItem.Name = "сохранитьПодписанныйToolStripMenuItem";
            сохранитьПодписанныйToolStripMenuItem.Size = new Size(258, 28);
            сохранитьПодписанныйToolStripMenuItem.Text = "Save signed file";
            сохранитьПодписанныйToolStripMenuItem.Click += saveSignedFileToolStripMenuItem_Click;
            // 
            // checkSignatureToolStripMenuItem
            // 
            checkSignatureToolStripMenuItem.Enabled = false;
            checkSignatureToolStripMenuItem.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkSignatureToolStripMenuItem.Name = "checkSignatureToolStripMenuItem";
            checkSignatureToolStripMenuItem.Size = new Size(247, 27);
            checkSignatureToolStripMenuItem.Text = "Check digital signature";
            checkSignatureToolStripMenuItem.Click += CheckSignatureToolStripMenuItemClick;
            // 
            // kTB
            // 
            kTB.BackColor = SystemColors.Window;
            kTB.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            kTB.ForeColor = Color.Black;
            kTB.Location = new Point(573, 216);
            kTB.MaxLength = 36;
            kTB.Name = "kTB";
            kTB.Size = new Size(367, 32);
            kTB.TabIndex = 31;
            kTB.Text = "31";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(645, 166);
            label2.Name = "label2";
            label2.Size = new Size(223, 30);
            label2.TabIndex = 33;
            label2.Text = "Parameter k (0, q)";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // xTB
            // 
            xTB.BackColor = SystemColors.Window;
            xTB.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            xTB.ForeColor = Color.Black;
            xTB.Location = new Point(200, 216);
            xTB.MaxLength = 36;
            xTB.Name = "xTB";
            xTB.Size = new Size(367, 32);
            xTB.TabIndex = 30;
            xTB.Text = "45";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(272, 166);
            label3.Name = "label3";
            label3.Size = new Size(223, 30);
            label3.TabIndex = 32;
            label3.Text = "Parameter x (0, q)";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // plaintextRTB
            // 
            plaintextRTB.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            plaintextRTB.Location = new Point(573, 315);
            plaintextRTB.Name = "plaintextRTB";
            plaintextRTB.Size = new Size(536, 226);
            plaintextRTB.TabIndex = 36;
            plaintextRTB.Text = "";
            // 
            // startButton
            // 
            startButton.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            startButton.Location = new Point(97, 493);
            startButton.Name = "startButton";
            startButton.Size = new Size(367, 48);
            startButton.TabIndex = 35;
            startButton.Text = "Compute";
            startButton.UseVisualStyleBackColor = true;
            startButton.Click += startButton_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(774, 261);
            label5.Name = "label5";
            label5.Size = new Size(135, 34);
            label5.TabIndex = 34;
            label5.Text = "Initial file";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dsTB
            // 
            dsTB.BackColor = SystemColors.Window;
            dsTB.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dsTB.ForeColor = Color.Black;
            dsTB.Location = new Point(97, 404);
            dsTB.MaxLength = 36;
            dsTB.Name = "dsTB";
            dsTB.ReadOnly = true;
            dsTB.Size = new Size(367, 32);
            dsTB.TabIndex = 39;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(178, 354);
            label8.Name = "label8";
            label8.Size = new Size(205, 30);
            label8.TabIndex = 40;
            label8.Text = "Digital signature";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // hashTB
            // 
            hashTB.BackColor = SystemColors.Window;
            hashTB.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            hashTB.ForeColor = Color.Black;
            hashTB.Location = new Point(97, 315);
            hashTB.MaxLength = 36;
            hashTB.Name = "hashTB";
            hashTB.ReadOnly = true;
            hashTB.Size = new Size(367, 32);
            hashTB.TabIndex = 37;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(247, 265);
            label9.Name = "label9";
            label9.Size = new Size(70, 30);
            label9.TabIndex = 38;
            label9.Text = "Hash";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // openFileDialog
            // 
            openFileDialog.Filter = "Text files|*.txt";
            // 
            // saveFileDialog
            // 
            saveFileDialog.Filter = "Text files|*.txt";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1132, 562);
            Controls.Add(dsTB);
            Controls.Add(label8);
            Controls.Add(hashTB);
            Controls.Add(label9);
            Controls.Add(plaintextRTB);
            Controls.Add(startButton);
            Controls.Add(label5);
            Controls.Add(kTB);
            Controls.Add(label2);
            Controls.Add(xTB);
            Controls.Add(label3);
            Controls.Add(hTB);
            Controls.Add(label7);
            Controls.Add(qTB);
            Controls.Add(label6);
            Controls.Add(pTB);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DSA";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox hTB;
        private Label label7;
        private TextBox qTB;
        private Label label6;
        private TextBox pTB;
        private Label label4;
        private Label label1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private TextBox kTB;
        private Label label2;
        private TextBox xTB;
        private Label label3;
        private RichTextBox plaintextRTB;
        private Button startButton;
        private Label label5;
        private TextBox dsTB;
        private Label label8;
        private TextBox hashTB;
        private Label label9;
        private ToolStripMenuItem checkSignatureToolStripMenuItem;
        private OpenFileDialog openFileDialog;
        private ToolStripMenuItem открытьToolStripMenuItem;
        private ToolStripMenuItem сохранитьПодписанныйToolStripMenuItem;
        private SaveFileDialog saveFileDialog;
    }
}