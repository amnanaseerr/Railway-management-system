using System;
using System.Data;
using System.Windows.Forms;

namespace RailwayReservationSystem
{
    public partial class UC_ViewReservations : UserControl
    {
        public UC_ViewReservations()
        {
            InitializeComponent();
        }

        // Method to load reservations into the DataGridView
        public void LoadReservations(DataTable reservations)
        {
            dataGridViewReservations.DataSource = reservations; // Bind the DataTable to the DataGridView
        }
    }
}
