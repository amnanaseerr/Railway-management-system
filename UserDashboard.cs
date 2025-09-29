using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; // Add this namespace for SQL-related classes

namespace RailwayReservationSystem
{
    public partial class UserDashboard : Form
    {
        // Store the currently logged-in user information
        private int currentUserId;
        private string currentUserName;

        public UserDashboard(int userId, string userName)
        {
            InitializeComponent();
            currentUserId = userId;
            currentUserName = userName;
        }

        private void UserDashboard_Load(object sender, EventArgs e)
        {
            // Set welcome message
            lblWelcome.Text = $"Welcome, {currentUserName}!";

            // Load the search trains control by default when the form loads
            LoadControl(new UC_SearchTrains());
        }

        // Method to load user controls in the main panel
        private void LoadControl(UserControl control)
        {
            panelMain.Controls.Clear();
            control.Dock = DockStyle.Fill;
            panelMain.Controls.Add(control);
        }

        private void btnSearchTrain_Click(object sender, EventArgs e)
        {
            LoadControl(new UC_SearchTrains());
        }

        private void btnViewTrainDetails_Click(object sender, EventArgs e)
        {
            // Will implement later
            MessageBox.Show("This feature is coming soon!", "Under Development", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //private void btnBookTicket_Click(object sender, EventArgs e)
        //{
        //    //// Will implement later
        //    //MessageBox.Show("This feature is coming soon!", "Under Development", MessageBoxButtons.OK, MessageBoxIcon.Information);

        //}
        private void btnBookTicket_Click(object sender, EventArgs e)
        {
            // Pass the currentUserId to the UC_BookTicket constructor
            UC_BookTicket bookTicketControl = new UC_BookTicket(currentUserId);
            bookTicketControl.Dock = DockStyle.Fill;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(bookTicketControl);
        }



        //private void btnViewTicket_Click(object sender, EventArgs e)
        //{
        //    // Will implement later
        //    MessageBox.Show("This feature is coming soon!", "Under Development", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //}

        private void btnViewTicket_Click(object sender, EventArgs e)
        {
            // Pass the currentUserId to the UC_ViewTicket constructor
            UC_ViewTicket viewTicketControl = new UC_ViewTicket(currentUserId);
            viewTicketControl.Dock = DockStyle.Fill;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(viewTicketControl);
        }



        //private void btnCancelTicket_Click(object sender, EventArgs e)
        //{
        //    // Will implement later
        //    MessageBox.Show("This feature is coming soon!", "Under Development", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //}

        private void btnCancelTicket_Click(object sender, EventArgs e)
        {
            // Pass the currentUserId to the UC_CancelTicket constructor
            UC_CancelTicket cancelTicketControl = new UC_CancelTicket(currentUserId);
            cancelTicketControl.Dock = DockStyle.Fill; // Ensure it fills the panel
            panelMain.Controls.Clear(); // Clear any existing controls
            panelMain.Controls.Add(cancelTicketControl); // Add the cancel ticket control
        }






        //private void btnViewProfile_Click(object sender, EventArgs e)
        //{
        //    // Will implement later
        //    MessageBox.Show("This feature is coming soon!", "Under Development", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //}

        //private void btnEditProfile_Click(object sender, EventArgs e)
        //{
        //    // Will implement later
        //    MessageBox.Show("This feature is coming soon!", "Under Development", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //}

        private void btnLogout_Click(object sender, EventArgs e)
        {
            // Go back to login form
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }

        private void panelSidebar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnUserLogout_Click(object sender, EventArgs e)
        {
            // Clear the current user session
            currentUserId = 0;
            currentUserName = string.Empty;

            // Redirect to the LoginForm
            LoginForm loginForm = new LoginForm();
            loginForm.Show();

            // Close the current UserDashboard form
            this.Close();
        }
    }
}

