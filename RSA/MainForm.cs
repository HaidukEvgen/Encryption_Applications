using System;
using System.IO;
using System.Numerics;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace RSA
{
    public partial class MainForm : System.Windows.Forms.Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        const int ITERATIONS = 50;
        const int MAX_MODULE = 65535;

        class RSAKeyPair
        {
            public BigInteger e;
            public BigInteger n;
            public override string ToString()
            {
                return "(" + e.ToString() + ", " + n.ToString() + ")";
            }
        }

        static bool IsPrime(BigInteger n)
        {
            if (n <= 1 || n == 4)
                return false;
            if (n <= 3)
                return true;

            BigInteger d = n - 1;
            int s = 0;
            while (d % 2 == 0)
            {
                d /= 2;
                s++;
            }

            for (int i = 0; i < ITERATIONS; i++)
            {
                byte[] bytes = new byte[n.ToByteArray().LongLength];
                BigInteger a;
                do
                {
                    using (var rng = new RNGCryptoServiceProvider())
                    {
                        rng.GetBytes(bytes);
                    }
                    a = new BigInteger(bytes);
                } while (a < 2 || a >= n - 2);

                BigInteger x = BigInteger.ModPow(a, d, n);
                if (x == 1 || x == n - 1)
                    continue;

                for (int j = 0; j < s - 1; j++)
                {
                    x = BigInteger.ModPow(x, 2, n);
                    if (x == 1)
                        return false;
                    if (x == n - 1)
                        break;
                }

                if (x != n - 1)
                    return false;
            }

            return true;
        }

        static bool AreCoprime(BigInteger a, BigInteger b)
        {
            BigInteger r;
            while (b != 0)
            {
                r = a % b;
                a = b;
                b = r;
            }

            return a == 1;
        }

        private bool IsCorrect(BigInteger p, BigInteger q, BigInteger d, BigInteger phiN, BigInteger n)
        {
            if (!IsPrime(p))
            {
                MessageBox.Show("Error: p is not a prime number.");
                return false;
            }
            if (!IsPrime(q))
            {
                MessageBox.Show("Error: q is not a prime number.");
                return false;
            }
            if (d <= 1 || d > phiN)
            {
                MessageBox.Show($"Error: the key must be in the interval [1; {phiN}], where {phiN} is the value of the Euler function of p and q");
                return false;
            }
            if (!AreCoprime(d, phiN))
            {
                MessageBox.Show($"Error: the key must be mutually simple with {phiN}, where {phiN} is the value of the Euler function of p and q");
                return false;
            }
            if (n >= MAX_MODULE)
            {
                MessageBox.Show($"Error: module n = p * q = {n} must be less than {MAX_MODULE}");
                return false;
            }
            return true;
        }

        private void encipherButton_Click(object sender, EventArgs eventArgs)
        {
            if (plaintextRTB.Text == "")
                return;
            if (!BigInteger.TryParse(pTB.Text, out BigInteger p))
            {
                MessageBox.Show("Error: p must be an integer");
                return;
            }
            if (!BigInteger.TryParse(qTB.Text, out BigInteger q))
            {
                MessageBox.Show("Error: q must be an integer");
                return;
            }
            if (!BigInteger.TryParse(closekeyTB.Text, out BigInteger d))
            {
                MessageBox.Show("Error: d must be an integer");
                return;
            }
            BigInteger n = p * q;
            BigInteger phiN = (p - 1) * (q - 1);
            if (!IsCorrect(p, q, d, phiN, n))
                return;
            BigInteger e = ModInverse(d, phiN);
            RSAKeyPair openKey = new() { e = e, n = n };
            openkeyTB.Text = openKey.ToString();
            // Шифрование
            byte[] inputFileBytes = GetBytes(plaintextRTB);
            BigInteger[] encryptedInts = new BigInteger[inputFileBytes.Length];
            for (int i = 0; i < inputFileBytes.Length; i++)
            {
                BigInteger m = new(inputFileBytes[i]);
                BigInteger c = FastExponentiation(m, e, n);
                encryptedInts[i] = c;
            }
            OutputEncryptedNums(encryptedInts, ciphertextRTB);
            saveToolStripMenuItem.Enabled = true;
            saveRegularFileToolStripMenuItem.Enabled = true;
        }

        private void decipherButton_Click(object sender, EventArgs eventArgs)
        {
            if (ciphertextRTB.Text == "")
                return;
            if (!BigInteger.TryParse(pTB.Text, out BigInteger p))
            {
                MessageBox.Show("Ошибка: p должно быть целым числом");
                return;
            }
            if (!BigInteger.TryParse(qTB.Text, out BigInteger q))
            {
                MessageBox.Show("Ошибка: q должно быть целым числом");
                return;
            }
            if (!BigInteger.TryParse(closekeyTB.Text, out BigInteger d))
            {
                MessageBox.Show("Ошибка: d должно быть целым числом");
                return;
            }
            BigInteger n = p * q;
            BigInteger phiN = (p - 1) * (q - 1);
            if (!IsCorrect(p, q, d, phiN, n))
                return;
            BigInteger[] inputFileBytes = GetInts(ciphertextRTB);
            BigInteger[] decryptedInts = new BigInteger[inputFileBytes.Length];
            for (int i = 0; i < inputFileBytes.Length; i++)
            {
                BigInteger m = inputFileBytes[i];
                BigInteger c = FastExponentiation(m, d, n);
                decryptedInts[i] = c;
            }
            OutputEncryptedNums(decryptedInts, plaintextRTB);
            saveToolStripMenuItem.Enabled = true;
            saveRegularFileToolStripMenuItem.Enabled = true;
        }

        static BigInteger MultInverseModN(BigInteger a, BigInteger n)
        {
            BigInteger iter(BigInteger aPrev, BigInteger a, BigInteger rPrev, BigInteger r)
            {
                if (r <= 1)
                {
                    return a;
                }
                else
                {
                    BigInteger rNext = BigInteger.Remainder(rPrev, r);
                    BigInteger q = BigInteger.Divide(rPrev, r);
                    BigInteger aNext = aPrev - (q * a);
                    return iter(a, aNext, r, rNext);
                }
            }

            BigInteger result = iter(0, 1, n, a);
            return result >= 0 ? result : (n + result);
        }

        static BigInteger ModInverse(BigInteger a, BigInteger m)
        {
            BigInteger m0 = m;
            BigInteger y = 0, x = 1;

            if (m == 1)
                return 0;

            while (a > 1)
            {
                BigInteger q = a / m;
                BigInteger t = m;

                m = a % m;
                a = t;
                t = y;

                y = x - q * y;
                x = t;
            }

            if (x < 0)
                x += m0;

            return x;
        }

        static BigInteger FastExponentiation(BigInteger baseNum, BigInteger exponent, BigInteger modulus)
        {
            BigInteger result = 1;

            while (exponent > 0)
            {
                if (exponent % 2 == 1)
                {
                    result = (result * baseNum) % modulus;
                }
                baseNum = (baseNum * baseNum) % modulus;
                exponent >>= 1;
            }
            return result;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = openFileDialog.FileName;
            plaintextRTB.Text = ReadFileBits(filename);
            ciphertextRTB.Text = "";
            openkeyTB.Text = "";
            saveToolStripMenuItem.Enabled = false;
            saveRegularFileToolStripMenuItem.Enabled = false;
        }
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = saveFileDialog.FileName;
            byte[] bytes = ConvertToByteArray(ciphertextRTB.Text);
            File.WriteAllBytes(filename, bytes);
        }

        private void openEncryptedFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = openFileDialog.FileName;
            ciphertextRTB.Text = ReadBytesFromFile(filename);
            plaintextRTB.Text = "";
            openkeyTB.Text = "";
            saveToolStripMenuItem.Enabled = false;
            saveRegularFileToolStripMenuItem.Enabled = false;
        }

        private void SaveRegularFileToolStripMenuItemClick(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = saveFileDialog.FileName;
            byte[] bytes = GetBytes(plaintextRTB);
            File.WriteAllBytes(filename, bytes);
        }

        public static byte[] ConvertToByteArray(string input)
        {
            string[] numbers = input.Trim().Split(' ');
            byte[] result = new byte[numbers.Length * 2];
            for (int i = 0; i < numbers.Length; i++)
            {
                ushort number;
                if (ushort.TryParse(numbers[i], out number))
                {
                    byte[] bytes = BitConverter.GetBytes(number);
                    Buffer.BlockCopy(bytes, 0, result, i * 2, 2);
                }
                else
                {
                    throw new ArgumentException($"It is not possible to convert the number {numbers[i]} into an array of bytes.");
                }
            }
            return result;
        }

        private byte[] GetBytes(RichTextBox textRTB)
        {
            string plaintext = textRTB.Text.Trim();
            string[] numbers = plaintext.Split(' ');
            byte[] result = new byte[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (byte.TryParse(numbers[i], out byte b))
                {
                    result[i] = b;
                }
                else
                {
                    throw new ArgumentException($"It is not possible to convert the number {numbers[i]} into a byte.");
                }
            }
            return result;
        }

        private BigInteger[] GetInts(RichTextBox textRTB)
        {
            string plaintext = textRTB.Text.Trim();
            string[] numbers = plaintext.Split(' ');
            BigInteger[] result = new BigInteger[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (BigInteger.TryParse(numbers[i], out BigInteger b))
                {
                    result[i] = b;
                }
                else
                {
                    throw new ArgumentException($"It is not possible to convert the number {numbers[i]} into a byte.");
                }
            }
            return result;
        }

        private string ReadFileBits(string filePath)
        {
            var result = new StringBuilder();
            using (FileStream stream = File.OpenRead(filePath))
            {
                byte[] buffer = new byte[1024];
                int bytesRead;
                while ((bytesRead = stream.Read(buffer, 0, buffer.Length)) > 0)
                {
                    for (int i = 0; i < bytesRead; i++)
                    {
                        result.Append(Convert.ToString(buffer[i]) + " ");
                    }
                }
            }
            return result.ToString();
        }

        private void OutputEncryptedNums(BigInteger[] encryptedInts, RichTextBox richTextBox)
        {
            var sb = new StringBuilder();
            foreach (BigInteger b in encryptedInts)
            {
                sb.Append($"{b} ");
            }
            richTextBox.Text = sb.ToString();
        }

        static string ReadBytesFromFile(string filePath)
        {
            byte[] bytes = File.ReadAllBytes(filePath);
            StringBuilder result = new();
            for (int i = 0; i < bytes.Length; i += 2)
            {
                if (i + 1 >= bytes.Length) break;
                byte[] twoBytes = new byte[2];
                twoBytes[0] = bytes[i];
                twoBytes[1] = bytes[i + 1];
                ushort number = BitConverter.ToUInt16(twoBytes, 0);
                result.Append(number + " ");
            }
            return result.ToString().Trim();
        }
    }
}
