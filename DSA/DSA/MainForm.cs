using System.Numerics;
using System.Text;

namespace Lab4
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public static bool IsPrime(BigInteger n)
        {
            int k = 50;
            if (n <= 1 || n == 4)
                return false;
            if (n <= 3)
                return true;

            BigInteger d = n - 1;
            while (d % 2 == 0)
                d /= 2;

            Random rand = new();
            for (int i = 0; i < k; i++)
            {
                BigInteger a = rand.Next(2, (int)n - 1);
                BigInteger x = BigInteger.ModPow(a, d, n);

                if (x == 1 || x == n - 1)
                    continue;

                for (int j = 0; j < (int)Math.Log2((int)n); j++)
                {
                    x = BigInteger.ModPow(x, 2, n);
                    if (x == n - 1)
                        break;
                    if (j == (int)Math.Log2((int)n) - 1)
                        return false;
                }
            }
            return true;
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

        private bool IsCorrect(BigInteger p, BigInteger q, BigInteger h, BigInteger x, BigInteger k)
        {
            if (!IsPrime(p))
            {
                MessageBox.Show("Error: p must be a prime number");
                return false;
            }
            if (!IsPrime(q))
            {
                MessageBox.Show("Error: q must be a prime number");
                return false;
            }
            if ((p - 1) % q != 0)
            {
                MessageBox.Show("Error: q is not a divisor of p - 1.");
                return false;
            }
            if (h < 1 || h > p - 1)
            {
                MessageBox.Show("Error: parameter h must fall within the interval (1, p-1)");
                return false;
            }
            if (FastExponentiation(h, (p - 1) / q, p) <= 1)
            {
                MessageBox.Show($"Error: g = h^((p-1)/q) mod p <= 1");
                return false;
            }
            if (x < 0 || x > q)
            {
                MessageBox.Show($"Error: parameter x must fall within the interval (0, q)");
                return false;
            }
            if (k < 0 || k > q)
            {
                MessageBox.Show($"Error: parameter k must fall within the interval (0, q)");
                return false;
            }
            return true;
        }

        public static BigInteger ComputeHash(byte[] M, BigInteger p, BigInteger q)
        {
            BigInteger n = p * q;
            BigInteger H = 100;

            foreach (byte Mi in M)
            {
                H = FastExponentiation(H + Mi, 2, n); // Hi = (Hi-1 + Mi)^2 mod n
            }

            return H;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
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
            if (!BigInteger.TryParse(hTB.Text, out BigInteger h))
            {
                MessageBox.Show("Error: h must be an integer");
                return;
            }
            if (!BigInteger.TryParse(xTB.Text, out BigInteger x))
            {
                MessageBox.Show("Error: x must be an integer");
                return;
            }
            if (!BigInteger.TryParse(kTB.Text, out BigInteger k))
            {
                MessageBox.Show("Error: k must be an integer");
                return;
            }
            if (!IsCorrect(p, q, h, x, k))
                return;
            BigInteger g = FastExponentiation(h, (p - 1) / q, p);
            byte[] inputFileBytes = lastOpenedFileBytes;
            BigInteger hash = ComputeHash(inputFileBytes, p, q);
            DS signature;
            try
            {
                signature = CountDigitalSignature(inputFileBytes, p, q, k, g, x, hash);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            hashTB.Text = hash.ToString();
            dsTB.Text = signature.ToString();
            checkSignatureToolStripMenuItem.Enabled = true;
        }

        private static DS CountDigitalSignature(byte[] inputFileBytes, BigInteger p, BigInteger q, BigInteger k, BigInteger g, BigInteger x, BigInteger hash)
        {
            BigInteger r, s;
            r = FastExponentiation(g, k, p) % q; // r = (g^k mod p) mod q
            BigInteger kInv = FastExponentiation(k, q - 2, q); // k^-1 mod q
            s = (kInv * (hash + x * r)) % q; // s = k^-1(h(M) + x*r) mod q
            if (r == 0)
                throw new Exception("The calculated value of r = 0. Use a different value for the k parameter");
            if (s == 0)
                throw new Exception("The calculated value of s = 0. Use a different value for the k parameter");
            return new DS(r, s);
        }

        private class DS
        {
            public BigInteger R { get; set; }
            public BigInteger S { get; set; }

            public DS()
            {
                R = 0;
                S = 0;
            }

            public DS(BigInteger r, BigInteger s)
            {
                R = r;
                S = s;
            }

            public DS(string line)
            {
                if (line == null || line == "")
                    throw new Exception("File is empty");
                string[] parts = line.Trim('(', ')').Split(',');
                try
                {
                    R = BigInteger.Parse(parts[0].Trim());
                    S = BigInteger.Parse(parts[1].Trim());
                }
                catch
                {
                    throw new Exception("There is an incorrect line with the Digital signature in the file");
                }
            }

            public override string ToString()
            {
                return "(" + R.ToString() + ", " + S.ToString() + ")";
            }
        }

        byte[] lastOpenedFileBytes;

        private void FillRichTextBox(string filePath, RichTextBox rtb)
        {
            using StreamReader sr = new(filePath);
            string text = sr.ReadToEnd();
            rtb.Text = text;
        }

        private byte[] ReadFileWithoutFirstLine(string fileName, ref DS signature)
        {
            byte[] fileBytes;

            using (var stream = new StreamReader(fileName))
            {
                signature = new(stream.ReadLine());
                fileBytes = Encoding.UTF8.GetBytes(stream.ReadToEnd());
            }

            return fileBytes;
        }


        private void CheckSignatureToolStripMenuItemClick(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = openFileDialog.FileName;
            DS signature = new();
            byte[] openedFileBytes;
            try
            {
                openedFileBytes = ReadFileWithoutFirstLine(filename, ref signature);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

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
            if (!BigInteger.TryParse(hTB.Text, out BigInteger h))
            {
                MessageBox.Show("Error: h must be an integer");
                return;
            }
            if (!BigInteger.TryParse(xTB.Text, out BigInteger x))
            {
                MessageBox.Show("Error: x must be an integer");
                return;
            }
            if (!BigInteger.TryParse(kTB.Text, out BigInteger k))
            {
                MessageBox.Show("Error: k must be an integer");
                return;
            }

            BigInteger g = FastExponentiation(h, (p - 1) / q, p);
            BigInteger y = FastExponentiation(g, x, p);

            BigInteger r = signature.R;
            BigInteger s = signature.S;
            BigInteger w = FastExponentiation(s, q - 2, q); //w = s^−1 mod q
            BigInteger hash = ComputeHash(openedFileBytes, p, q);
            BigInteger u1 = hash * w % q; //u1 = h(M) * w mod q
            BigInteger u2 = r * w % q; //u2 = r * w mod q
            BigInteger v = FastExponentiation(g, u1, p) * FastExponentiation(y, u2, p) % p % q;
            if (v == r)
            {
                MessageBox.Show($"Digital signature is valid\nhash = {hash}\nw = {w}\nu1 = {u1}\nu2 = {u2}\nv = {v} = r", "digital signature verification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"Digital signature is invalid\nhash = {hash}\nw = {w}\nu1 = {u1}\nu2 = {u2}\nv = {v} != r", "digital signature verification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = openFileDialog.FileName;
            lastOpenedFileBytes = File.ReadAllBytes(filename);
            FillRichTextBox(filename, plaintextRTB);
        }

        private void saveSignedFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = saveFileDialog.FileName;
            File.WriteAllText(filename, dsTB.Text + "\n" + plaintextRTB.Text);
        }
    }
}