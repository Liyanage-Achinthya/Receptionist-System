using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomatedReceptionistSystem
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String username = txtBoxUsername.Text;
            String passowrd = txtBoxPassword.Text;

            if (username == "ABC" && passowrd == "123")
            {
                //MessageBox.Show("Login Sucessfull!");

                frmServices frmServices = new frmServices();
                frmServices.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Check username or password");
            }
        }

        private void btnNewUser_Click(object sender, EventArgs e)
        {
            frmNewUser newUserForm = new frmNewUser();
            newUserForm.Show();
            this.Hide();

        }
    }
}
