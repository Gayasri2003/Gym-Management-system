﻿using System;
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
        private static string connectionString = @"Data Source=(local)\SQLEXPRESS;Initial Catalog=GymDatabase;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
        private static SqlDbType memberId;

        public DB_Helper() { }
        public DB_Helper(string connString)
        {
            connectionString = connString;
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
            WHERE u.Username = @Username";


                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Username", username);


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
                                "",
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
            string query = @"UPDATE Users SET FirstName = @FirstName, LastName = @LastName,DateOfBirth = @DateOfBirth, ContactNumber = @ContactNumber, City = @City, Email = @Email, " +
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


                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    return false;
                }
            }
        }

        // make attendance
        public static int ExecuteNonQuery(string query, SqlParameter[] parameters = null)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    if (parameters != null)
                        cmd.Parameters.AddRange(parameters);
                    return cmd.ExecuteNonQuery();
                }
            }
        }

        // Execute SELECT queries and return DataTable
        public static DataTable ExecuteQuery(string query, SqlParameter[] parameters = null)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    if (parameters != null)
                        cmd.Parameters.AddRange(parameters);
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        return dt;
                    }
                }
            }
        }
        //check username exists
        public static bool CheckIfUsernameExists(string username)
        {
            string query = "SELECT COUNT(*) FROM Members WHERE Username = @username";
            SqlParameter[] parameters = { new SqlParameter("@username", username) };

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddRange(parameters);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                }
            }
        }
        // Check if attendance already exists for today
        public static bool AttendanceExists(string username)
        {
            string query = "SELECT COUNT(*) FROM Attendance WHERE Username = @username AND Date = CAST(GETDATE() AS DATE)";
            SqlParameter[] parameters = { new SqlParameter("@username", username) };

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddRange(parameters);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                }
            }
        }

        // Insert new attendance record
        public static int MarkAttendance(string username, bool isPresent)
        {
            if (AttendanceExists(username))
            {
                return -1;
            }

            string query = "INSERT INTO Attendance (Username, Date, IsPresent) VALUES (@username, GETDATE(), @IsPresent)";
            SqlParameter[] parameters = {
            new SqlParameter("@username", username),
            new SqlParameter("@IsPresent", isPresent)
        };

            return ExecuteNonQuery(query, parameters);
        }

        // Get attendance history for a member
        public static DataTable GetAttendanceHistory(string username)
        {
            string query = "SELECT AttendanceId, Date, IsPresent FROM Attendance WHERE Username = @username ORDER BY Date DESC";
            SqlParameter[] parameters = { new SqlParameter("@username", username) };

            return ExecuteQuery(query, parameters);
        }

        // Update attendance record 
        public static int UpdateAttendance(int attendanceId, bool isPresent)
        {
            string query = "UPDATE Attendance SET IsPresent = @IsPresent WHERE AttendanceId = @AttendanceId";
            SqlParameter[] parameters = {
            new SqlParameter("@IsPresent", isPresent),
            new SqlParameter("@AttendanceId", attendanceId)
        };

            return ExecuteNonQuery(query, parameters);
        }


        internal bool UpdateMemberProfile()
        {
            throw new NotImplementedException();
        }

        
        public DataTable GetPaymentsByUserID(int userID)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Payments WHERE UserID = @UserID";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@UserID", userID); // Ensure @UserID is properly declared

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        return dt;
                    }
                }
            }
        }
        // Add Payment 
        public static int AddPayment(string username, decimal amount, DateTime paymentDate, string paymentMethod)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                string getMemberIDQuery = "SELECT MemberID FROM Members WHERE UserID = (SELECT UserID FROM Users WHERE Username = @Username)";

                using (SqlCommand getMemberCmd = new SqlCommand(getMemberIDQuery, con))
                {
                    getMemberCmd.Parameters.AddWithValue("@Username", username);

                    var memberID = getMemberCmd.ExecuteScalar();
                    if (memberID == null) return 0;

                    string insertPaymentQuery = "INSERT INTO Payments (UserID, Amount, PaymentDate, PaymentMethod) VALUES (@UserID, @Amount, @PaymentDate, @PaymentMethod)";

                    using (SqlCommand insertCmd = new SqlCommand(insertPaymentQuery, con))
                    {
                        insertCmd.Parameters.AddWithValue("@UserID", Convert.ToInt32(memberID));
                        insertCmd.Parameters.AddWithValue("@Amount", amount);
                        insertCmd.Parameters.AddWithValue("@PaymentDate", paymentDate);
                        insertCmd.Parameters.AddWithValue("@PaymentMethod", paymentMethod);

                        return insertCmd.ExecuteNonQuery();
                    }
                }
            }
        }

        // Get Payment History 
        public static DataTable GetPaymentHistory(string username)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"
                SELECT p.PaymentID, u.Username, p.Amount, p.PaymentDate, p.PaymentMethod
                 FROM Payments p
                 INNER JOIN Users u ON p.UserID = u.UserID
                 WHERE u.Username = @Username
                 ORDER BY p.PaymentDate DESC";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        return dt;
                    }
                }
            }
        }
    }
}
