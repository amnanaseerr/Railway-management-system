using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace RailwayReservationSystem
{
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }

        // Method to load the user controls dynamically
        private void LoadControl(UserControl control)
        {
            panelMainContent.Controls.Clear(); // Clear any existing controls
            control.Dock = DockStyle.Fill; // Make the control fill the panel
            panelMainContent.Controls.Add(control); // Add the new control to the panel
        }

        // Method to fetch all reservations from the database
        private DataTable GetAllReservations()
        {
            // Connection string to the database
            string connectionString = @"Server=.;Database=RailwayReservationSystem;Trusted_Connection=True;";

            // SQL query to fetch all reservations
            string query = "SELECT reservationID, userID, trainID, journeyDate, numberOfSeatsBooked, reservationStatus FROM Reservations";

            // Create a DataTable to store the results
            DataTable reservationsTable = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Open the connection
                    connection.Open();

                    // Create a SqlCommand to execute the query
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Create a SqlDataAdapter to fill the DataTable
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(reservationsTable); // Fill the DataTable with the query results
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions (e.g., log the error or show a message)
                MessageBox.Show($"An error occurred while fetching reservations: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return reservationsTable; // Return the filled DataTable
        }

        // Button click for adding a train
        private void btnAddTrain_Click(object sender, EventArgs e)
        {
            panelMainContent.Controls.Clear(); // Clear anything inside the panel

            UC_AddTrain addTrainForm = new UC_AddTrain(); // Create the Add Train form
            addTrainForm.Dock = DockStyle.Fill; // Make it fill the panel

            panelMainContent.Controls.Add(addTrainForm);
        }

        // Button click for viewing all trains
        private void btnViewAllTrains_Click(object sender, EventArgs e)
        {
            // Load ViewAllTrainsControl when btnViewAllTrains is clicked
            panelMainContent.Controls.Clear(); // Clear old content
            UC_ViewTrains viewTrainsControl = new UC_ViewTrains(); // Create new control
            viewTrainsControl.Dock = DockStyle.Fill;
            panelMainContent.Controls.Add(viewTrainsControl); // Load it into the panel
        }

        // Button click for viewing reservations
        private void btnViewReservations_Click(object sender, EventArgs e)
        {
            // Fetch all reservations
            DataTable reservations = GetAllReservations();

            // Create a new instance of UC_ViewReservations
            UC_ViewReservations viewReservationsControl = new UC_ViewReservations();

            // Load the reservations data into the control
            viewReservationsControl.LoadReservations(reservations);

            // Load the control into the main panel
            LoadControl(viewReservationsControl);
        }

        // Button click for canceling a reservation
        private void btnCancelReservation_Click(object sender, EventArgs e)
        {
            // Load CancelReservationControl when btnCancelReservation is clicked
        }

        // Button click for viewing users
        private void btnViewUsers_Click(object sender, EventArgs e)
        {
            // Load ViewUsersControl when btnViewUsers is clicked
            LoadControl(new ViewUsersControl()); // Load ViewUsersControl into the main panel
        }

        // Button click for deleting a user
        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            // Load DeleteUserControl when btnDeleteUser is clicked
            LoadControl(new DeleteUserControl());
        }

        // Button click for logging out
        private void btnLogout_Click(object sender, EventArgs e)
        {
            // Implement logout functionality, such as closing the form or redirecting to a login page
            this.Close(); // Close the AdminDashboard form when logged out
            //Redirect to the Login Screen 
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void panelMainContent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDeleteTrain_Click(object sender, EventArgs e)
        {
            LoadControl(new DeleteTrainControl());
        }
    }
}
