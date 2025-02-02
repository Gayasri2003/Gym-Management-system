using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym_Management_System_SDAM2
{
    public class Members:User
    {
    
        public DateTime? MembershipStartDate { get; set; }
        public string MembershipType { get; set; }

        public Members(int userID, string firstName, string lastName, DateTime dateOfBirth, string contactNumber, string city, string email, string username, string password, string gender, string role, DateTime? membershipStartDate, string membershipType)
            : base(firstName, lastName, dateOfBirth, contactNumber, city, email, username, password, gender, role)
        {
            UserID = userID;
            MembershipStartDate = membershipStartDate;
           
        }

        public void DisplayMemberProfile()
        {
            DisplayUserInfo();
            Console.WriteLine($"Membership Start Date: {MembershipStartDate?.ToShortDateString() ?? "Not Assigned"}");
            Console.WriteLine($"Membership Type: {MembershipType ?? "Not Assigned"}");
        }
    }

}
