using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace ContainerTerminalApp.UI.Services
{
    class AuthService
    {
        public static bool ValidateCredentials(string dbUsername, string dbPassword, string username, string password, out string role)
        {
            role = null;
            try
            {
                using var conn = DB_Service.GetConnection(dbUsername, dbPassword);
                using var cmd = new NpgsqlCommand(
                    "SELECT password_hash, role FROM users WHERE username = @u", conn); cmd.Parameters.AddWithValue("u", username);
                using var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    string storedPassword = reader.GetString(0);
                    role = reader.GetString(1);

                    return storedPassword == password;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Failed authenticating: {ex.Message}");
            }
            return false;
        }
    }
}
