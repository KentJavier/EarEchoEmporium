using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                errorProvider1.Clear();
                errorProvider1.SetError(txtRPass, "Empty Field. Please input the required information.");
                return;
            }

            if (String.IsNullOrEmpty(txtRConNum.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtRConNum, "Empty Field. Please input the required information.");
                return;
            }

            errorProvider1.Clear();

            ErrorCode res = userRepo.Register(txtRFName.Text, txtRLName.Text, txtREmail.Text, txtRPass.Text, txtRConNum.Text);
            if (res != ErrorCode.Success) 
            {
                txtRFName.Clear();
                txtRLName.Clear();
                txtREmail.Clear();
                txtRPass.Clear();
                txtRConNum.Clear();
            }
        }
    }
}
