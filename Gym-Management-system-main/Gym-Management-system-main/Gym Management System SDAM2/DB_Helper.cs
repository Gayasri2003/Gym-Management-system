using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym_Management_System_SDAM2
{
    public class DB_Helper
    {
        private string connectionString = @"Data Source=DESKTOP-28I7HML\SQLEXPRESS;Initial Catalog=Gym_Management_System_SDAM2;Integrated Security=True;TrustServerCertificate=True";

        //Register new user 
        public bool RegisterUser(User user)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Users (FirstName, LastName, DateOfBirth, ContactNumber, City, Email, Gender, Role, Username, Password) " +
                               "VALUES (@FirstName, @LastName, @DOB, @Contact, @City, @Email, @Gender, @Role, @Username, @Password)";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@FirstName", user.FirstName);
                cmd.Parameters.AddWithValue("@LastName", user.LastName);
                cmd.Parameters.AddWithValue("@DOB", user.DateOfBirth);
                cmd.Parameters.AddWithValue("@Contact", user.ContactNumber);
                cmd.Parameters.AddWithValue("@City", user.City);
                cmd.Parameters.AddWithValue("@Email", user.Email);
                cmd.Parameters.AddWithValue("@Gender", user.Gender);
                cmd.Parameters.AddWithValue("@Role", user.Role);
                cmd.Parameters.AddWithValue("@Username", user.Username);
                cmd.Parameters.AddWithValue("@Password", user.Password);

                try
                {
                    conn.Open();
                    int result = cmd.ExecuteNonQuery();
                    return result > 0;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    return false;
                }
            }
        }

        // For login
        public bool LoginUser(string username, string password)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = @"SELECT COUNT(1) FROM Users WHERE Username = @Username AND Password = @Password";

                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);

                    int count = Convert.ToInt32(command.ExecuteScalar());
                    return count > 0;
                }
            }
        }

        // for display member details in the member profile page

        public Members GetMemberProfile(string username, string password)
        {
        using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
            SELECT u.*, m.MembershipStartDate, m.MembershipType
            FROM Users u
            JOIN Members m ON u.UserID = m.UserID
            WHERE u.Username = @Username AND u.Password = @Password";

            
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", password);

                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read()) 
                        {
                            return new Members(

                                Convert.ToInt32(reader["UserID"]),
                                reader["FirstName"].ToString(),
                                reader["LastName"].ToString(),
                                Convert.ToDateTime(reader["DateOfBirth"]),
                                reader["ContactNumber"].ToString(),
                                reader["City"].ToString(),
                                reader["Email"].ToString(),
                                reader["Gender"].ToString(),
                                reader["Username"].ToString(),
                                reader["Password"].ToString(),
                                reader["Role"].ToString(),
                                reader["MembershipStartDate"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(reader["MembershipStartDate"]),
                                reader["MembershipType"] == DBNull.Value ? null : reader["MembershipType"].ToString()
                                );      
                        }
                    }
                }
                return null;
            }
        }
    }
}
