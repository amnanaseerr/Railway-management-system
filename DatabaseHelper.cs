using System;
using System.Data.SqlClient;

namespace RailwayReservationSystem
{
    public static class DatabaseHelper
    {
        // Updated connection string to use the local SQL Server instance
        private static string connectionString = @"Server=.;Database=RailwayReservationSystem;Trusted_Connection=True;";

        // Method to connect to the database and execute a query
        public static SqlConnection GetConnection()
        {
            try
            {
                return new SqlConnection(connectionString); // Return a new, closed connection
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error connecting to database: {ex.Message}");
                throw;
            }
        }

    }
}
