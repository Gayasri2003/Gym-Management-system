using Gym_Management_System_SDAM2;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;



namespace Gym_Management_System_SDAM2
{
    public class User
    {
        public int UserID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }

        private string contactNumber;
        public string ContactNumber
        {
            get { return contactNumber; }
            set
            {
                if (Regex.IsMatch(value, @"^\d{8,15}$"))
                {
                    contactNumber = value;
                }
                else
                {
                    throw new ArgumentException("Contact number must contain only numbers.");
                }
            }
        }

        public string City { get; set; }
        public string Email { get; set; }

        private string gender;
        public string Gender
        {
            get { return gender; }
            set
            {
                if (value == "Male" || value == "Female")
                {
                    gender = value;
                }
                else
                {
                    throw new ArgumentException("Invalid gender selection.");
                }
            }
        }

        private string role;
        public string Role
        {
            get { return role; }
            set
            {
                if (value == "Trainer" || value == "Member")
                {
                    role = value;
                }
                else
                {
                    throw new ArgumentException("Invalid role selection.");
                }
            }
        }
        public string Username { get; set; }

        private string password;
        public string Password
        {
            get { return password; }
            private set
            {
                if (value.Length >= 6)
                {
                    password = value;
                }
                else
                {
                    throw new ArgumentException("Password must be at least 8 characters long.");
                }
            }
        }



        //set password
        public void SetPassword(string password)
        {
            Password = password;
        }

        // confirm password
        public bool VerifyPassword(string enteredPassword)
        {
            return Password == enteredPassword;
        }

        // Constructor for User class
        public User(string firstName, string lastName, DateTime dateOfBirth, string contactNumber, string city, string email, string username, string password, string gender, string role)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            ContactNumber = contactNumber;
            City = city;
            Email = email;
            Username = username;
            SetPassword(password); 
            Gender = gender;
            Role = role;
        }
        public void DisplayUserInfo()
        {
            Console.WriteLine($"Name: {FirstName} {LastName}");
            Console.WriteLine($"Date of Birth: {DateOfBirth.ToShortDateString()}");
            Console.WriteLine($"Contact: {ContactNumber}");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine($"City: {City}");
            Console.WriteLine($"Gender: {Gender}");
            Console.WriteLine($"Username: {Username}");
            Console.WriteLine($"Role: {Role}");
        }
    }
}