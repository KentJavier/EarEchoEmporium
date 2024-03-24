using EarEchoEmporium.AppData;
using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace EarEchoEmporium
{
    public partial class frmRegister : Form
    {
        private UserRepository userRepo;

        public frmRegister()
        {
            InitializeComponent();

            userRepo = new UserRepository();
            errorProvider = new ErrorProvider();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtRFName.Text))
            {
                errorProvider.Clear();
                errorProvider.SetError(txtRFName, "Empty Field. Please input the required information.");
                return;
            }

            if (String.IsNullOrEmpty(txtRLName.Text))
            {
                errorProvider.Clear();
                errorProvider.SetError(txtRLName, "Empty Field. Please input the required information.");
                return;
            }

            if (String.IsNullOrEmpty(txtREmail.Text))
            {
                errorProvider.Clear();
                errorProvider.SetError(txtREmail, "Empty Field. Please input the required information.");
                return;
            }

            if (String.IsNullOrEmpty(txtRPass.Text))
            {
                errorProvider.Clear();
                errorProvider.SetError(txtRPass, "Empty Field. Please input the required information.");
                return;
            }

            if (String.IsNullOrEmpty(txtRConNum.Text))
            {
                errorProvider.Clear();
                errorProvider.SetError(txtRConNum, "Empty Field. Please input the required information.");
                return;
            }

            if (String.IsNullOrEmpty(txtRAddress.Text))
            {
                errorProvider.Clear();
                errorProvider.SetError(txtRAddress, "Empty Field. Please input the required information.");
                return;
            }

            errorProvider.Clear();

            // Hash the password before storing it in the database
            string hashedPassword = GetSHA256Hash(txtRPass.Text);

            ErrorCode res = userRepo.Register(txtRFName.Text, txtRLName.Text, txtREmail.Text, hashedPassword, txtRConNum.Text, txtRAddress.Text);
            if (res == ErrorCode.Success)
            {
                MessageBox.Show("Account successfully registered!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Failed to register account. Error: " + res.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void pbBack_Click(object sender, EventArgs e)
        {
            frmLogin loginForm = new frmLogin();
            loginForm.Show();
            this.Hide();
        }
    }
}
