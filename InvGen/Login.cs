using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;

namespace InvGen
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            Left = Top = 0;
            Width = Screen.PrimaryScreen.WorkingArea.Width;
            Height = Screen.PrimaryScreen.WorkingArea.Height;
            MaximizeBox = true;
            WindowState = FormWindowState.Maximized;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string uname = txtUserName.Text.ToString();
            string password = txtPassword.Text.ToString();

            SqlConnectionInfo db = new SqlConnectionInfo();
            string role = db.ValidateUser(uname, Encrypt(password));


            if (role == "")
            {
                txtUserName.Text = "";
                txtPassword.Text = "";
                MessageBox.Show("Invalid Username / Password");
                return;
            }
            if (role == "Admin")
            {
                txtUserName.Visible = false;
                txtPassword.Visible = false;
                lblPassword.Visible = false;
                lblUsername.Visible = false;
                btnLogin.Visible = false;
                menuStrip1.Visible = true;
                userToolStripMenuItem.Visible = false;
            }
            if (role == "User")
            {
                txtUserName.Visible = false;
                txtPassword.Visible = false;
                lblPassword.Visible = false;
                lblUsername.Visible = false;
                btnLogin.Visible = false;
                menuStrip1.Visible = true;
                adminToolStripMenuItem.Visible = false;
            }

        }
        public string Encrypt(string encryptString)
        {
            string EncryptionKey = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            byte[] clearBytes = Encoding.Unicode.GetBytes(encryptString);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] {  
            0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76  
        });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(clearBytes, 0, clearBytes.Length);
                        cs.Close();
                    }
                    encryptString = Convert.ToBase64String(ms.ToArray());
                }
            }
            return encryptString;
        }

        public string Decrypt(string cipherText)
        {
            string EncryptionKey = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            cipherText = cipherText.Replace(" ", "+");
            byte[] cipherBytes = Convert.FromBase64String(cipherText);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] {  
            0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76  
        });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(cipherBytes, 0, cipherBytes.Length);
                        cs.Close();
                    }
                    cipherText = Encoding.Unicode.GetString(ms.ToArray());
                }
            }
            return cipherText;
        }

        private void businessPartnersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Partners form = new Partners(); form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog();
        }

        private void invoiceToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Invoice inv = new Invoice(); inv.StartPosition = FormStartPosition.CenterParent;
            inv.ShowDialog();
        }

        private void invoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Invoice inv = new Invoice(); inv.StartPosition = FormStartPosition.CenterParent;
            inv.ShowDialog();
        }

        private void itemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Items form = new Items(); form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog();
        }
    }
}
