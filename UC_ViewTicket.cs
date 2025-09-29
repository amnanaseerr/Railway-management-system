using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace RailwayReservationSystem
{
    public partial class UC_ViewTicket : UserControl
    {
        private int loggedInUserID; // Field to store the logged-in user's ID

        public UC_ViewTicket(int userID)
        {
            InitializeComponent();
            loggedInUserID = userID; // Assign the logged-in user's ID
        }

        private void UC_ViewTicket_Load(object sender, EventArgs e)
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
                    // Query to get reservations with train details
                    string query = @"SELECT r.reservationID AS 'Reservation ID', 
                                     t.trainName AS 'Train Name',
                                     t.sourceStation AS 'Source',
                                     t.destinationStation AS 'Destination',
                                     FORMAT(r.journeyDate, 'yyyy-MM-dd') AS 'Journey Date',
                                     FORMAT(t.departureDateTime, 'HH:mm') AS 'Departure Time',
                                     r.numberOfSeatsBooked AS 'Seats Booked',
                                     r.reservationStatus AS 'Status'
                                     FROM Reservations r
                                     JOIN Trains t ON r.trainID = t.trainID
                                     WHERE r.userID = @UserID
                                     ORDER BY r.journeyDate DESC";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Use the logged-in user's ID
                        cmd.Parameters.AddWithValue("@UserID", loggedInUserID);

                        conn.Open();
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        dataGridViewTickets.DataSource = dt;
                        conn.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading reservations: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadReservations();
        }

        private void btnViewDetails_Click(object sender, EventArgs e)
        {
            if (dataGridViewTickets.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a reservation to view details.", "No Reservation Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string reservationID = dataGridViewTickets.SelectedRows[0].Cells["Reservation ID"].Value.ToString();

            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    string query = @"SELECT r.reservationID, 
                                     t.trainName, 
                                     t.sourceStation, 
                                     t.destinationStation,
                                     FORMAT(r.journeyDate, 'yyyy-MM-dd') AS JourneyDate,
                                     FORMAT(t.departureDateTime, 'HH:mm') AS DepartureTime,
                                     FORMAT(t.arrivalDateTime, 'HH:mm') AS ArrivalTime,
                                     r.numberOfSeatsBooked,
                                     r.reservationStatus,
                                     u.fullName AS PassengerName
                                     FROM Reservations r
                                     JOIN Trains t ON r.trainID = t.trainID
                                     JOIN Users u ON r.userID = u.userID
                                     WHERE r.reservationID = @ReservationID";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ReservationID", reservationID);

                        conn.Open();
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            string details = $"Reservation ID: {reader["reservationID"]}\n" +
                                           $"Train Name: {reader["trainName"]}\n" +
                                           $"Passenger: {reader["PassengerName"]}\n" +
                                           $"From: {reader["sourceStation"]}\n" +
                                           $"To: {reader["destinationStation"]}\n" +
                                           $"Journey Date: {reader["JourneyDate"]}\n" +
                                           $"Departure Time: {reader["DepartureTime"]}\n" +
                                           $"Arrival Time: {reader["ArrivalTime"]}\n" +
                                           $"Seats Booked: {reader["numberOfSeatsBooked"]}\n" +
                                           $"Status: {reader["reservationStatus"]}";

                            MessageBox.Show(details, "Reservation Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Reservation details not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        conn.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving reservation details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
