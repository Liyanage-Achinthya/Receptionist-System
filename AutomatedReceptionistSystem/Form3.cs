using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace AutomatedReceptionistSystem
{
    public partial class frmServices : Form
    {
        private string Username;
        public frmServices(string username)
        {
            Username = username;    
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            bool bodyWash = checkedListBoxServices.CheckedItems.Contains("Body Wash");
            bool interiorClean = checkedListBoxServices.CheckedItems.Contains("Interior Clean");
            bool fullService = checkedListBoxServices.CheckedItems.Contains("Full Service");
            bool bodyPaintRepairs = checkedListBoxServices.CheckedItems.Contains("Body/Paint Repairs");

            int serviceBay = AssignServiceBay();
            if (serviceBay > 0)
            {
                if (SubmitServiceRequest(Username, bodyWash, interiorClean, fullService, bodyPaintRepairs, serviceBay))
                {
                    MessageBox.Show($"Service assign to bay{serviceBay}");
                    frmCheckout CheckoutForm = new frmCheckout(serviceBay);
                    CheckoutForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Failed to submit service request.");
                }
            }
            else
            {
                MessageBox.Show("No service bay available. Please wait.");
            }
        }

        private int AssignServiceBay()
        {
            using (SqlConnection con = new SqlConnection("Data Source=LAPTOP-1IUB1TEF\\SQLEXPRESS;Initial Catalog=AutomatedReceptionistSystemDB;Integrated Security=True"))
            {
                con.Open();
                using (SqlTransaction transaction = con.BeginTransaction())
                {
                    try
                    {
                        // Checking for an available bay
                        string checkQuery = "SELECT TOP 1 BayId FROM ServiceBays WHERE IsOccupied = 0";
                        SqlCommand checkCmd = new SqlCommand(checkQuery, con, transaction);
                        object result = checkCmd.ExecuteScalar();

                        if (result != null)
                        {
                            int BayId = (int)result;

                            // Mark the bay as occupied
                            string updateQuery = "UPDATE ServiceBays SET IsOccupied = 1 WHERE BayId = @bayId";
                            SqlCommand updateCmd = new SqlCommand(updateQuery, con, transaction);
                            updateCmd.Parameters.AddWithValue("@bayId", BayId);
                            updateCmd.ExecuteNonQuery();

                            transaction.Commit();

                            return BayId;
                        }

                        else
                        {
                            // No bay available
                            return -1;
                        }
                    }

                    catch
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }
        private bool SubmitServiceRequest(string username, bool bodyWash, bool interiorClean, bool fullService, bool bodyPaintRepairs, int serviceBay)
        {
            using (SqlConnection con = new SqlConnection("Data Source=LAPTOP-1IUB1TEF\\SQLEXPRESS;Initial Catalog=AutomatedReceptionistSystemDB;Integrated Security=True"))
            {
                con.Open();
                string query = "INSERT INTO Services (UserId, BodyWash, InteriorClean, FullService, BodyPaintRepairs, ServiceBay) " +
                               "VALUES ((SELECT UserId FROM Users WHERE Username = @username), @bodyWash, @interiorClean, @fullService, @bodyPaintRepairs, @serviceBay)";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@bodyWash", bodyWash);
                    cmd.Parameters.AddWithValue("@interiorClean", interiorClean);
                    cmd.Parameters.AddWithValue("@fullService", fullService);
                    cmd.Parameters.AddWithValue("@bodyPaintRepairs", bodyPaintRepairs);
                    cmd.Parameters.AddWithValue("@serviceBay", serviceBay);

                    int result = cmd.ExecuteNonQuery();
                    return result > 0;
                }
            }

        }
    }
}
