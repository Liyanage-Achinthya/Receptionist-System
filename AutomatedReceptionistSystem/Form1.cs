using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

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
            String password = txtBoxPassword.Text;

            SqlConnection con = new SqlConnection("Data Source=LAPTOP-1IUB1TEF\\SQLEXPRESS;Initial Catalog=AutomatedReceptionistSystemDB;Integrated Security=True");
            con.Open();
            String queary = "SELECT COUNT(*) FROM Users WHERE Username = @Username AND Password = @Password";
            SqlCommand cmd = new SqlCommand(queary, con);
            cmd.Parameters.AddWithValue("@Username", txtBoxUsername.Text);
            cmd.Parameters.AddWithValue("@Password", txtBoxPassword.Text);
            int count = (int)cmd.ExecuteScalar();
            con.Close();

            if (count > 0)
            {
                MessageBox.Show("Login Sucessfull!");

                frmServices ServicesForm = new frmServices(username);
                ServicesForm.Show();
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

        private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtBoxPassword.PasswordChar = checkBoxShowPassword.Checked ? '\0' : '*';
        }
    }
}
