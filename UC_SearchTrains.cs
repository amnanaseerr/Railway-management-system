using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace RailwayReservationSystem
{
    public partial class UC_SearchTrains : UserControl
    {
        public UC_SearchTrains()
        {
            InitializeComponent();
        }

        private void UC_SearchTrains_Load(object sender, EventArgs e)
        {
            // Set default date to today
            dateTimePickerJourneyDate.Value = DateTime.Today;

            // Clear any previous search results
            dataGridViewSearchResults.DataSource = null;
        }

        private void btnSearchTrain_Click(object sender, EventArgs e)
        {
            // Get search parameters
            string source = txtSourceStation.Text.Trim();
            string destination = txtDestinationStation.Text.Trim();

            // Validate input
            if (string.IsNullOrWhiteSpace(source) || string.IsNullOrWhiteSpace(destination))
            {
                MessageBox.Show("Please enter both source and destination stations.",
                               "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    // Updated search query (removed date filter)
                    string query = @"SELECT 
                                    trainID AS 'Train ID', 
                                    trainName AS 'Train Name', 
                                    sourceStation AS 'Source', 
                                    destinationStation AS 'Destination', 
                                    FORMAT(departureDateTime, 'yyyy-MM-dd HH:mm') AS 'Departure Time', 
                                    FORMAT(arrivalDateTime, 'yyyy-MM-dd HH:mm') AS 'Arrival Time', 
                                    totalAvailableSeats AS 'Available Seats'
                                FROM Trains 
                                WHERE sourceStation LIKE @Source 
                                AND destinationStation LIKE @Destination
                                ORDER BY departureDateTime";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Parameters
                        cmd.Parameters.AddWithValue("@Source", "%" + source + "%");
                        cmd.Parameters.AddWithValue("@Destination", "%" + destination + "%");

                        // Fill data table
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        // Display results
                        dataGridViewSearchResults.DataSource = dt;

                        // Status message
                        if (dt.Rows.Count > 0)
                        {
                            lblSearchStatus.Text = $"Found {dt.Rows.Count} trains matching your criteria.";
                            lblSearchStatus.ForeColor = System.Drawing.Color.Green;
                        }
                        else
                        {
                            lblSearchStatus.Text = "No trains found for the selected criteria.";
                            lblSearchStatus.ForeColor = System.Drawing.Color.Red;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching trains: " + ex.Message,
                               "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblSearchStatus.Text = "Error occurred while searching.";
                lblSearchStatus.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}
