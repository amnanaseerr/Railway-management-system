using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace RailwayReservationSystem
{
    public partial class DeleteTrainControl : UserControl
    {
        public DeleteTrainControl()
        {
            InitializeComponent();
        }

        private void DeleteTrainControl_Load(object sender, EventArgs e)
        {
            // You can add any initialization code here if required
        }

        private void txtTrainID_TextChanged(object sender, EventArgs e)
        {
            // Optionally, you can handle any text changes here (if needed)
        }

        private void btnDeleteTrain_Click(object sender, EventArgs e)
        {
            // Check if the Train ID field is empty
            if (string.IsNullOrWhiteSpace(txtTrainID.Text))
            {
                lblStatus.Text = "Please enter a Train ID.";
                return;
            }

            // Try to parse the Train ID as an integer
            int trainId;
            if (!int.TryParse(txtTrainID.Text, out trainId))
            {
                lblStatus.Text = "Train ID must be a valid number.";
                return;
            }

            // Corrected connection string to your SQL Server
            string connectionString = @"Server=.;Database=RailwayReservationSystem;Trusted_Connection=True;";

            // Use a connection to the database
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    // Open the connection
                    conn.Open();

                    // SQL Query to delete the train with the specified TrainID
                    string query = "DELETE FROM Trains WHERE TrainID = @TrainID";

                    // Create a command object to execute the query
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@TrainID", trainId);

                    // Execute the query and get the number of rows affected
                    int rowsAffected = cmd.ExecuteNonQuery();

                    // Check if a train was successfully deleted
                    if (rowsAffected > 0)
                    {
                        lblStatus.ForeColor = System.Drawing.Color.Green;
                        lblStatus.Text = "Train deleted successfully.";
                    }
                    else
                    {
                        lblStatus.ForeColor = System.Drawing.Color.Red;
                        lblStatus.Text = "No train found with that ID.";
                    }
                }
                catch (Exception ex)
                {
                    // Catch any exceptions and display the error message
                    lblStatus.Text = "Error: " + ex.Message;
                }
            }
        }
    }
}
