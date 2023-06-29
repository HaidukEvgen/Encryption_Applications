using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace TI2
{
    public partial class MainForm : System.Windows.Forms.Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private const int RANK = 36;

        private void encipherButton_Click(object sender, EventArgs e)
        {
            string initialState = GetInitialState();
            if (initialState.Length != RANK)
            {
                MessageBox.Show(string.Format("Initial state has {0} bits, but has to have {1} bits", initialState.Length, RANK));
                return;
            }
            LFSR lfsr = new LFSR(initialState, new int[] { 11, 36 });
            keyRTB.Text = lfsr.Generate(plaintextRTB.Text.Length);
            ciphertextRTB.Text = Encode();
            saveToolStripMenuItem.Enabled = true;
        }

        private string Encode()
        {
            string text = plaintextRTB.Text, key = keyRTB.Text;
            StringBuilder sb = new StringBuilder(plaintextRTB.Text.Length);
            for (int i = 0; i < text.Length; i++)
            {
                sb.Append((text[i] - '0') ^ (key[i] - '0'));
            }
            return sb.ToString();
        }

        private string GetInitialState()
        {
            string initialState = "";
            foreach (var ch in initialStateTB.Text)
            {
                if (ch == '1' || ch == '0')
                {
                    initialState += ch;
                }
            }
            return initialState;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = openFileDialog.FileName;
            plaintextRTB.Text = ReadFileBits(filename);
            keyRTB.Text = "";
            ciphertextRTB.Text = "";
            saveToolStripMenuItem.Enabled = false;
        }

        private string ReadFileBits(string filePath)
        {
            StringBuilder result = new StringBuilder();
            using (FileStream stream = File.OpenRead(filePath))
            {
                byte[] buffer = new byte[1024];
                int bytesRead;
                while ((bytesRead = stream.Read(buffer, 0, buffer.Length)) > 0)
                {
                    for (int i = 0; i < bytesRead; i++)
                    {
                        result.Append(Convert.ToString(buffer[i], 2).PadLeft(8, '0'));
                    }
                }
            }
            return result.ToString();
        }

        private void initialStateTB_TextChanged(object sender, EventArgs e)
        {
            if (GetInitialState().Length == RANK)
            {
                initialStateTB.ForeColor = Color.Green;
                encipherButton.Enabled = true;
            }
            else
            {
                initialStateTB.ForeColor = Color.Red;
                encipherButton.Enabled = false;
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = saveFileDialog.FileName;
            int numOfBytes = ciphertextRTB.Text.Length / 8;
            byte[] bytes = new byte[numOfBytes];
            string text = ciphertextRTB.Text;
            for (int i = 0; i < numOfBytes; ++i)
            {
                bytes[i] = Convert.ToByte(text.Substring(8 * i, 8), 2);
            }
            File.WriteAllBytes(filename, bytes);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
