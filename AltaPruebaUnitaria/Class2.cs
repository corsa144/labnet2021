using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Engine.Moq
{
    public class PlayerDataMapper : IPlayerDataMapper
    {
        private readonly string _connectionString =
            @"data source = (localdb)\.; initial catalog = Northwind; integrated security = True";

        public bool PlayerNameExistsInDatabase(int id,string phone, string companyName)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                using (SqlCommand playersWithThisName = connection.CreateCommand())
                {
                    playersWithThisName.CommandType = CommandType.Text;
                    playersWithThisName.CommandText = "SELECT count(*) FROM Northwind WHERE 'Id' = @Id";

                    //playersWithThisName.Parameters.AddWithValue("@Name", name);
                    playersWithThisName.Parameters.AddWithValue("@Phone", phone);
                    playersWithThisName.Parameters.AddWithValue("@CompanyName", companyName);
                    // Get the number of player with this name 
                    var existingRowCount = (int)playersWithThisName.ExecuteScalar();

                    // Result is 0, if no player exists, or 1, if a player already exists
                    return existingRowCount > 0;
                }
            }
        }

        public void InsertNewPlayerIntoDatabase(int id, string phone, string companyName)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                using (SqlCommand playersWithThisName = connection.CreateCommand())
                {
                    playersWithThisName.CommandType = CommandType.Text;
                    playersWithThisName.CommandText = "INSERT INTO Northwind ([id]) VALUES (@id)";

                    playersWithThisName.Parameters.AddWithValue("@Phone", phone);
                    playersWithThisName.Parameters.AddWithValue("@CompanyName", companyName);

                    playersWithThisName.ExecuteNonQuery();
                }
            }
        }
    }
}
