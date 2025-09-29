//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;
//using System.Data.SqlClient; // Add this namespace for SQL-related classes

using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace RailwayReservationSystem
{
    public partial class UC_BookTicket : UserControl
    {
        private int loggedInUserID; // Field to store the logged-in user's ID

        public UC_BookTicket(int userID)
        {
            InitializeComponent();
            loggedInUserID = userID; // Assign the logged-in user's ID
        }

        private void UC_BookTicket_Load(object sender, EventArgs e)
        {
            // Load available trains into a dropdown or grid
            LoadAvailableTrains();
        }

        private void LoadAvailableTrains()
        {
            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    string query = @"SELECT trainID, trainName, sourceStation, destinationStation, 
                                     FORMAT(departureDateTime, 'yyyy-MM-dd HH:mm') AS DepartureTime, 
                                     totalAvailableSeats 
                                     FROM Trains 
                                     WHERE totalAvailableSeats > 0";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridViewAvailableTrains.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading trains: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            if (dataGridViewAvailableTrains.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a train to book.", "No Train Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string trainID = dataGridViewAvailableTrains.SelectedRows[0].Cells["trainID"].Value.ToString();
            string passengerName = txtPassengerName.Text.Trim();
            int numberOfSeats = (int)numericUpDownSeats.Value;
            DateTime journeyDate = DateTime.Now; // Assuming the journey date is today; modify as needed
            string reservationStatus = "Confirmed"; // Default status for a new reservation

            if (string.IsNullOrWhiteSpace(passengerName) || numberOfSeats <= 0)
            {
                MessageBox.Show("Please enter valid passenger details.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Insert reservation into the Reservations table
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    string insertQuery = @"INSERT INTO Reservations (userID, trainID, journeyDate, numberOfSeatsBooked, reservationStatus) 
                                           VALUES (@UserID, @TrainID, @JourneyDate, @NumberOfSeats, @ReservationStatus)";

                    using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@UserID", loggedInUserID); // Use the logged-in user's ID
                        cmd.Parameters.AddWithValue("@TrainID", trainID);
                        cmd.Parameters.AddWithValue("@JourneyDate", journeyDate);
                        cmd.Parameters.AddWithValue("@NumberOfSeats", numberOfSeats);
                        cmd.Parameters.AddWithValue("@ReservationStatus", reservationStatus);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                }

                // Update the total available seats in the Trains table
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    string updateQuery = @"UPDATE Trains 
                                           SET totalAvailableSeats = totalAvailableSeats - @NumberOfSeats 
                                           WHERE trainID = @TrainID";

                    using (SqlCommand cmd = new SqlCommand(updateQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@TrainID", trainID);
                        cmd.Parameters.AddWithValue("@NumberOfSeats", numberOfSeats);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Reservation made successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadAvailableTrains(); // Refresh train list
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error booking reservation: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
