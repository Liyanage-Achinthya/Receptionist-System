using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomatedReceptionistSystem
{
    public partial class frmNewUser : Form
    {
        public frmNewUser()
        {
            InitializeComponent();
        }

        private void frmNewUser_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            try
            {
                String username = txtBoxUsername.Text;
                int phone = Convert.ToInt32(txtBoxPhone.Text);
                String password = txtBoxPassword.Text;

                using (SqlConnection con = new SqlConnection("Data Source=LAPTOP-1IUB1TEF\\SQLEXPRESS;Initial Catalog=AutomatedReceptionistSystemDB;Integrated Security=True"))
                {
                    con.Open();
                    String query = "INSERT INTO Users (Username, Phone, Password) VALUES (@Username, @Phone, @Password)";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@Phone", phone);
                        cmd.Parameters.AddWithValue("@Password", password);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Data saved successfully");
                            frmLogin newLoginForm = new frmLogin();
                            newLoginForm.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Failed to save data");
                        }
                    }
                }

                txtBoxUsername.Clear();
                txtBoxPhone.Clear();
                txtBoxPassword.Clear();
            }
            catch (Exception)
            {
                MessageBox.Show("An error occurred. Please try again.");
            }
        }
    }
}
