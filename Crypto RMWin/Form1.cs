using System;
using System.Windows.Forms;
using WarNov.AesManagedWrapper.Win32;

namespace CryptoRMWin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            var ss = txtSS.Text;
            var txt = txtText.Text;
            var encTxt = RMWCrypto.EncryptStringAES(txt, ss);
            var decTxt = RMWCrypto.DecryptStringAES(encTxt, ss);
            txtEncrypt.Text = encTxt;
            txtDecrypt.Text = decTxt;
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            var ss = txtSS.Text;
            var encTxt = txtEncrypt.Text;
            var decTxt = RMWCrypto.DecryptStringAES(encTxt, ss);
            txtDecrypt.Text = decTxt;
        }

        private void btnAutogenerate_Click(object sender, EventArgs e)
        {
            int value = (int)nudMain.Value;
            PasswordGenerator pg = new PasswordGenerator()
            {
                ConsecutiveCharacters = true,
                Maximum = value,
                Minimum = value - 1,
                RepeatCharacters = true
            };
            pg.Length = value;
            txtSS.Text = pg.Generate();
        }
    }
}