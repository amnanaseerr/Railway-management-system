using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace RailwayReservationSystem
{
    public partial class UC_AddTrain : UserControl
    {
        public UC_AddTrain()
        {
            InitializeComponent();
        }

        private void UC_AddTrain_Load(object sender, EventArgs e)
        {
            // Format Departure Picker
            dtDeparture.Format = DateTimePickerFormat.Custom;
            dtDeparture.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            dtDeparture.ShowUpDown = true;

            // Format Arrival Picker
            dtArrival.Format = DateTimePickerFormat.Custom;
            dtArrival.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            dtArrival.ShowUpDown = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtTrainName_Click(object sender, EventArgs e)
        {

        }

        //private void btnAddTrain_Click(object sender, EventArgs e)
        //{

        //}

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

      
        private void txtTrainName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSource_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDestination_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtDeparture_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtArrival_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnAddTrain_Click_1(object sender, EventArgs e)
        {
            string trainName = txtTrainName.Text;
            string source = txtSource.Text;
            string destination = txtDestination.Text;
            DateTime departure = dtDeparture.Value;
            DateTime arrival = dtArrival.Value;
            int totalSeats = (int)numSeats.Value;

            // 2. Validation (optional)
            if (string.IsNullOrWhiteSpace(trainName) || string.IsNullOrWhiteSpace(source) || string.IsNullOrWhiteSpace(destination))
            {
                MessageBox.Show("Please fill in all the required fields.");
                return;
            }

            // 3. Connection string (replace YOUR_SERVER_NAME with your real SQL Server name)
            string connectionString = @"Data Source=.;Initial Catalog=RailwayReservationSystem;Integrated Security=True";

            // 4. SQL Insert Command
            string query = @"INSERT INTO Trains (trainName, sourceStation, destinationStation, departureDateTime, arrivalDateTime, totalAvailableSeats)
                     VALUES (@trainName, @source, @destination, @departure, @arrival, @seats)";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // 5. Add parameters to prevent SQL Injection
                        cmd.Parameters.AddWithValue("@trainName", trainName);
                        cmd.Parameters.AddWithValue("@source", source);
                        cmd.Parameters.AddWithValue("@destination", destination);
                        cmd.Parameters.AddWithValue("@departure", departure);
                        cmd.Parameters.AddWithValue("@arrival", arrival);
                        cmd.Parameters.AddWithValue("@seats", totalSeats);

                        conn.Open();
                        int result = cmd.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Train added successfully!");
                        ClearForm(); // Optional: Reset fields
                        }
                        else
                        {
                            MessageBox.Show("Something went wrong.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void ClearForm()
        {
            txtTrainName.Text = "";
            txtSource.Text = "";
            txtDestination.Text = "";
            dtDeparture.Value = DateTime.Now;
            dtArrival.Value = DateTime.Now;
            numSeats.Value = 1;
        }

    }


}
