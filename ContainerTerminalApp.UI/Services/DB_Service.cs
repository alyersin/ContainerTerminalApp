using Npgsql;
using System;
using System.Windows;

namespace ContainerTerminalApp.UI.Services
{
    public static class DB_Service
    {

      


        public static NpgsqlConnection GetConnection(string dbUsername, string dbPassword)
        {
            string connectionString = $"Host={ServerDetails.Host};Port={ServerDetails.Port};Username={dbUsername};Password={dbPassword};Database={ServerDetails.Database}";
            var conn = new NpgsqlConnection(connectionString);

            try
            {
                conn.Open();
                if (conn.State == System.Data.ConnectionState.Open)
                {
                    Console.WriteLine("Connected to the DB");
                    return conn;
                }
                else
                {
                    throw new Exception("Failed to connect to the DB.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Database connection failed: , {ex.Message}");
            }
        }
    }
}
