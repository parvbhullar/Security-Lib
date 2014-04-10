using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Oranikle.Security.Studio
{
    public partial class SecurityStudio : Form
    {
        public SecurityStudio()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            try
            {
                txtEncryptionResult.Text = Encryption.Encrypt(txtEncryptionText.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text);
            }
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            try
            {
                txtEncryptionResult.Text = Encryption.Decrypt(txtEncryptionText.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text);
            }
        }

        private void btnHash_Click(object sender, EventArgs e)
        {
            try
            {
                txtHashResult.Text = Hashing.CreateHash(txtHashText.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text);
            }
        }
    }
}
