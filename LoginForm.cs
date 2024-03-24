using EarEchoEmporium.AppData;
using System;
using System.Data.Entity;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace EarEchoEmporium
{
    public partial class frmLogin : Form
    {
        private UserRepository userRepo;
        private ErrorProvider errorProvider;

        public frmLogin()
        {
            InitializeComponent();
            userRepo = new UserRepository();
            errorProvider = new ErrorProvider();
        }

        private void lblReg_Click(object sender, EventArgs e)
        {
            frmRegister regForm = new frmRegister();
            regForm.Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string password = txtPass.Text;

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Hash the password
            string hashedPassword = GetSHA256Hash(password);

            // Authenticate user
            bool isAuthenticated = userRepo.AuthenticateUser(email, hashedPassword);

            if (isAuthenticated)
            {
                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPass.Clear();
            }
        }

        private string GetSHA256Hash(string input)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(input);
                byte[] hashBytes = sha256.ComputeHash(bytes);

                StringBuilder builder = new StringBuilder();
                foreach (byte b in hashBytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }

        private void cbShowPass_CheckedChanged(object sender, EventArgs e)
        {
            txtPass.UseSystemPasswordChar = !cbShowPass.Checked;
        }
    }
}
