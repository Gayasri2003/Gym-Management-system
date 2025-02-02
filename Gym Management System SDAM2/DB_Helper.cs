using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym_Management_System_SDAM2
{
    public class DB_Helper
    {
        private string connectionString = @"Data Source=(local)\SQLEXPRESS;Initial Catalog=GymDatabase;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

        public DB_Helper(string connectionString)
        {
            this.connectionString = connectionString;
        }

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
        // Get Available Gym Classes
        public List<GymClass> GetAvailableClasses()
        {
            List<GymClass> classes = new List<GymClass>();
            string query = "SELECT ClassId, ClassName, Instructor, Schedule FROM Classes WHERE Available = 1";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            classes.Add(new GymClass(
                                Convert.ToInt32(reader["ClassId"]),
                                reader["ClassName"].ToString(),
                                reader["Instructor"].ToString(),
                                reader["Schedule"].ToString()
                            ));
                        }
                    }
                }
            }

            return classes;
        }

        // join class form

        public List<GymClass> GetAvailableClassesForComboBox()
        {
            List<GymClass> classes = new List<GymClass>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT ClassID, ClassName, Instructor, Schedule FROM Classes WHERE Available = 1";
                SqlCommand cmd = new SqlCommand(query, conn);

                try
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        GymClass gymClass = new GymClass(
                            (int)reader["ClassID"],
                            reader["ClassName"].ToString(),
                            reader["Instructor"].ToString(),
                            reader["Schedule"].ToString()
                        );
                        classes.Add(gymClass);
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error fetching available classes: " + ex.Message);
                }    
            }
            return classes;
        }
        // get details for join form
        public GymClass GetClassDetailsByID(int classID)
        {
            GymClass gymClass = null;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT ClassID, ClassName, Trainer, Schedule FROM Classes WHERE ClassID = @ClassID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ClassID", classID);

                try
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        gymClass = new GymClass(
                            (int)reader["ClassID"],
                            reader["ClassName"].ToString(),
                            reader["Trainer"].ToString(),
                            reader["Schedule"].ToString()
                        );
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error fetching class details: " + ex.Message);
                }
            }
            return gymClass;
        }
        //save member selection
        public void SaveMemberClassSelection(int memberID, int classID)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                // Check if the member is already enrolled 
                string checkQuery = "SELECT COUNT(*) FROM MemberClasses WHERE MemberID = @MemberID AND ClassID = @ClassID";
                SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
                checkCmd.Parameters.AddWithValue("@MemberID", memberID);
                checkCmd.Parameters.AddWithValue("@ClassID", classID);

                try
                {
                    conn.Open();
                    int count = (int)checkCmd.ExecuteScalar(); 

                    if (count == 0) 
                    {
                        string insertQuery = "INSERT INTO MemberClasses (MemberID, ClassID) VALUES (@MemberID, @ClassID)";
                        SqlCommand insertCmd = new SqlCommand(insertQuery, conn);
                        insertCmd.Parameters.AddWithValue("@MemberID", memberID);
                        insertCmd.Parameters.AddWithValue("@ClassID", classID);
                        insertCmd.ExecuteNonQuery();

                        MessageBox.Show("Class joined successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("You have already joined this class.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error saving class selection: " + ex.Message);
                }
            }
        }
        // update edit profile details to database
        public bool UpdateMemberProfile(Members member)
        {
            string query = "UPDATE Members SET FirstName = @FirstName, LastName = @LastName,DateOfBirth = @DateOfBirth, ContactNumber = @ContactNumber, City = @City, Email = @Email, " +
                           "Username = @Username, Password = @Password, Gender = @Gender, MembershipType = @MembershipType WHERE UserID = @UserID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@FirstName", member.FirstName);
                command.Parameters.AddWithValue("@LastName", member.LastName);
                command.Parameters.AddWithValue("@DateOfBirth", member.DateOfBirth);
                command.Parameters.AddWithValue("@ContactNumber", member.ContactNumber);
                command.Parameters.AddWithValue("@City", member.City);
                command.Parameters.AddWithValue("@Email", member.Email);
                command.Parameters.AddWithValue("@Username", member.Username);
                command.Parameters.AddWithValue("@Password", member.Password);
                command.Parameters.AddWithValue("@Gender", member.Gender);
                command.Parameters.AddWithValue("@MembershipType", member.MembershipType);
                command.Parameters.AddWithValue("@UserID", member.UserID);

                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }
    }

}
