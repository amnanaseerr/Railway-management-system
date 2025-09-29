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
    public partial class UC_ViewTrains : UserControl
    {
        string connectionString = "Server=.;Database=RailwayReservationSystem;Integrated Security=True;";

        public UC_ViewTrains()
        {
            InitializeComponent();
           
        }

        private void UC_ViewTrains_Load(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT trainID, trainName, sourceStation, destinationStation, departureDateTime, arrivalDateTime, totalAvailableSeats FROM Trains";
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dataGridViewTrains.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading train data: " + ex.Message);
            }
        }


    }
}
