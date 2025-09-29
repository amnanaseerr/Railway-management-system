using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace RailwayReservationSystem
{
    public partial class UC_CancelTicket : UserControl
    {
        private int loggedInUserID; // Field to store the logged-in user's ID

        public UC_CancelTicket(int userID)
        {
            InitializeComponent();
            loggedInUserID = userID; // Assign the logged-in user's ID
        }

        private void UC_CancelTicket_Load(object sender, EventArgs e)
        {
            // Load all reservations for the current user
            LoadReservations();
        }

        private void LoadReservations()
        {
            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    string query = @"SELECT r.reservationID AS 'Reservation ID', 
                                     t.trainName AS 'Train Name',
                                     t.sourceStation AS 'Source',
                                     t.destinationStation AS 'Destination',
                                     FORMAT(r.journeyDate, 'yyyy-MM-dd') AS 'Journey Date',
                                     r.numberOfSeatsBooked AS 'Seats Booked',
                                     r.reservationStatus AS 'Status'
                                     FROM Reservations r
                                     JOIN Trains t ON r.trainID = t.trainID
                                     WHERE r.userID = @UserID AND r.reservationStatus = 'Confirmed'
                                     ORDER BY r.journeyDate DESC";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@UserID", loggedInUserID); // Filter by logged-in user's ID

                        conn.Open();
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        dataGridViewReservations.DataSource = dt;
                        conn.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading reservations: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelReservation_Click(object sender, EventArgs e)
        {
            if (dataGridViewReservations.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a reservation to cancel.", "No Reservation Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string reservationID = dataGridViewReservations.SelectedRows[0].Cells["Reservation ID"].Value.ToString();
            int numberOfSeats = Convert.ToInt32(dataGridViewReservations.SelectedRows[0].Cells["Seats Booked"].Value);
            string trainID = dataGridViewReservations.SelectedRows[0].Cells["Train Name"].Value.ToString();
            string enteredName = txtPassengerName.Text.Trim();

            if (string.IsNullOrWhiteSpace(enteredName))
            {
                MessageBox.Show("Please enter your name to cancel the reservation.", "Name Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Validate the user's name and ownership of the reservation
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    string validateQuery = @"SELECT COUNT(*) 
                                             FROM Reservations r
                                             JOIN Users u ON r.userID = u.userID
                                             WHERE r.reservationID = @ReservationID 
                                             AND u.fullName = @FullName 
                                             AND r.userID = @UserID";

                    using (SqlCommand cmd = new SqlCommand(validateQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@ReservationID", reservationID);
                        cmd.Parameters.AddWithValue("@FullName", enteredName);
                        cmd.Parameters.AddWithValue("@UserID", loggedInUserID); // Ensure the reservation belongs to the logged-in user

                        conn.Open();
                        int count = (int)cmd.ExecuteScalar();
                        conn.Close();

                        if (count == 0)
                        {
                            MessageBox.Show("The entered name does not match your reservation.", "Invalid Name or Unauthorized", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                }

                // Update reservation status to "Cancelled"
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    string updateReservationQuery = @"UPDATE Reservations 
                                                      SET reservationStatus = 'Cancelled' 
                                                      WHERE reservationID = @ReservationID";

                    using (SqlCommand cmd = new SqlCommand(updateReservationQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@ReservationID", reservationID);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }
                }

                // Restore the seats in the Trains table
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    string updateTrainQuery = @"UPDATE Trains 
                                                SET totalAvailableSeats = totalAvailableSeats + @NumberOfSeats 
                                                WHERE trainID = @TrainID";

                    using (SqlCommand cmd = new SqlCommand(updateTrainQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@NumberOfSeats", numberOfSeats);
                        cmd.Parameters.AddWithValue("@TrainID", trainID);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }
                }

                MessageBox.Show("Reservation cancelled successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadReservations(); // Refresh the reservations list
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error cancelling reservation: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
