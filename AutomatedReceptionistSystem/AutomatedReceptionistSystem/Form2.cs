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
                String Username = txtBoxUsername.Text;
                int phone = Convert.ToInt32(txtBoxPhone.Text);
                String password = txtBoxPassword.Text;

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = LAPTOP-1IUB1TEF\\SQLEXPRESS; database = AutomatedReceptionistSystemDB; intergrated security = True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "insert into Users values('' + User_Id + '' + Username + '' + Phone + '' + Password)";

                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);
            }
            catch (Exception)
            {
                MessageBox.Show("");
            }

            MessageBox.Show("Data saved sucessfully");

            txtBoxUsername.Clear();
            txtBoxPhone.Clear();
            txtBoxPassword.Clear();
        }
    }
}
