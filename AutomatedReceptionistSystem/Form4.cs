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
    public partial class frmCheckout : Form
    {
        private int ServiceBay;
        public frmCheckout(int serviceBay)
        {
            ServiceBay = serviceBay;
            InitializeComponent();
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            if (CompleteService(ServiceBay))
            {
                MessageBox.Show("Service completed successfully.");
                frmLogin LognForm = new frmLogin();
                LognForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Failed to complete service.");
            }
        }

        private bool CompleteService(int serviceBay)
        {
            using (SqlConnection con = new SqlConnection("Data Source=LAPTOP-1IUB1TEF\\SQLEXPRESS;Initial Catalog=AutomatedReceptionistSystemDB;Integrated Security=True"))
            {
                string query = "UPDATE Services SET IsOccupied = 1 WHERE ServiceBay = @serviceBay AND IsOccupied = 0";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@serviceBay", serviceBay);
                con.Open();
                int result = cmd.ExecuteNonQuery();
                return result > 0;
            }
        }
    }
}
