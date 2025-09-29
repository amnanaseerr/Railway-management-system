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
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxFullName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxContact_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            string fullName = textBoxFullName.Text.Trim();
            string email = textBoxEmail.Text.Trim();
            string password = textBoxPassword.Text.Trim();
            string contactNumber = textBoxContact.Text.Trim();

            // Check if any field is empty
            if (string.IsNullOrEmpty(fullName) || string.IsNullOrEmpty(email) ||
                string.IsNullOrEmpty(password) || string.IsNullOrEmpty(contactNumber))
            {
                MessageBox.Show("Please fill all fields.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Database connection
                string connectionString = "Server=.;Database=RailwayReservationSystem;Integrated Security=True;";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Insert user into the Users table
                    string query = "INSERT INTO Users (fullName, emailAddress, passwordHash, contactNumber, userRole) " +
                                   "VALUES (@FullName, @Email, @Password, @ContactNumber, 'Customer')"; // Default 'Customer' role

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@FullName", fullName);
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Password", password); // Store the plain password
                        cmd.Parameters.AddWithValue("@ContactNumber", contactNumber);

                        // Execute the query to insert the data
                        cmd.ExecuteNonQuery();

                        // If everything is successful, show a success message
                        MessageBox.Show("Account created successfully! Please log in.", "SignUp Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Optionally, go back to the login screen after successful signup
                        //this.Hide();
                        //LoginForm loginForm = new LoginForm();
                        //loginForm.Show();
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle any errors that may occur
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonBackToLogin_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }
    }
}
