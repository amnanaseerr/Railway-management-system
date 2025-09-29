using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace RailwayReservationSystem
{
    public partial class LoginForm : Form
    {
        // Connection string to connect to the database
        string connectionString = "Server=.;Database=RailwayReservationSystem;Integrated Security=True;";

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            textBoxEmail.Focus();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string email = textBoxEmail.Text.Trim();
            string password = textBoxPassword.Text.Trim();

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both Email and Password.", "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Query to validate user credentials
                    string query = "SELECT userID, fullName, userRole FROM Users WHERE emailAddress = @Email AND passwordHash = @Password";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Password", password); // Plaintext password comparison

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                int userId = Convert.ToInt32(reader["userID"]);
                                string name = reader["fullName"].ToString();
                                string role = reader["userRole"].ToString();

                                MessageBox.Show($"Welcome, {name}!\nRole: {role}", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                this.Hide(); // Hide the login form

                                if (role == "Admin"|| role == "admin")
                                {
                                    // Redirect to Admin Dashboard
                                    AdminDashboard dashboard = new AdminDashboard();
                                    dashboard.Show();
                                }
                                else
                                {
                                    // Redirect to User Dashboard
                                    UserDashboard userDashboard = new UserDashboard(userId, name);
                                    userDashboard.Show();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Invalid email or password!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            SignUpForm signUpForm = new SignUpForm();
            signUpForm.Show();
            this.Hide();
        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {
            // Optional: Add behavior for email text changes if needed
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Optional: Add behavior for label click if needed
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // Optional: Add behavior for label click if needed
        }
    }
}
