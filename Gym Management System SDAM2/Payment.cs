using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym_Management_System_SDAM2
{
    public class Payment
    {
        public int PaymentID { get; set; }
        public string Username { get; set; }
        public decimal Amount { get; set; }
        public DateTime PaymentDate { get; set; }
        public string PaymentMethod { get; set; }

        public Payment(string username, decimal amount, DateTime paymentDate, string paymentMethod)
        {
            Username = username;
            Amount = amount;
            PaymentDate = paymentDate;
            PaymentMethod = paymentMethod;
        }
    }
}
