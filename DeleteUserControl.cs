using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace RailwayReservationSystem
{
    public partial class DeleteUserControl : UserControl
    {
        public DeleteUserControl()
        {
            InitializeComponent();
        }

        private void txtUserID_TextChanged(object sender, EventArgs e)
        {
            // Optionally, you can add any behavior here when the text changes in the UserID textbox.
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            // Check if UserID is empty
            if (string.IsNullOrWhiteSpace(txtUserID.Text))
            {
                MessageBox.Show("Please enter a User ID.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Try to parse the UserID
            int userId;
            if (!int.TryParse(txtUserID.Text, out userId))
            {
                MessageBox.Show("User ID must be a valid number.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Prevent deletion of admin user (UserID = 5)
            if (userId == 5)
            {
                MessageBox.Show("You cannot delete the admin user.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;  // Exit the method, preventing the deletion
            }

            // Call the method to delete the user
            DeleteUser(userId);
        }

        // Method to delete the user from the database
        private void DeleteUser(int userId)
        {
            string connectionString = @"Server=.;Database=RailwayReservationSystem;Trusted_Connection=True;";
            string query = "DELETE FROM Users WHERE UserID = @UserID";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();  // Open the connection to the database

                    // Prepare the command to execute the delete query
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@UserID", userId);  // Add UserID parameter to the command

                    // Execute the query and get the number of rows affected
                    int rowsAffected = cmd.ExecuteNonQuery();

                    // If rows are affected, show success message
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("User deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No user found with that ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    // Catch any exceptions and show an error message
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
