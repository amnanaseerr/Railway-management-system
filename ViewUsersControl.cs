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

namespace RailwayReservationSystem
{
    public partial class ViewUsersControl : UserControl
    {
        public ViewUsersControl()
        {
            InitializeComponent();
        }

        private void ViewUsersControl_Load(object sender, EventArgs e)
        {
            LoadUsers();
        }

        private void LoadUsers()
        {
            // Define your connection string
            string connectionString = @"Server=.;Database=RailwayReservationSystem;Trusted_Connection=True;";


            // SQL query to fetch user data (you can adjust the query based on your actual database schema)
            string query = "SELECT userID, fullName, emailAddress, passwordHash, contactNumber, userRole FROM Users";  // Modify as needed

            // Establish the SQL connection
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    // Open the connection
                    conn.Open();

                    // Set up the command and the data adapter
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, conn);

                    // Create a DataTable to store the fetched data
                    DataTable dataTable = new DataTable();

                    // Fill the DataTable with the data
                    dataAdapter.Fill(dataTable);

                    // Bind the data to the DataGridView
                    dataGridViewUsers.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    // Display an error message if there is an exception
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        //private void dataGridViewUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{

        //}
    }
}
