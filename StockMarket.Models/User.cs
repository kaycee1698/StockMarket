using System;
using System.Collections.Generic;
using System.Text;

namespace StockMarket.Models
{
    class User
    {
        public long Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public enum UserType
        {
            Admin,
            User
        }
        public string Email { get; set; }
        public string MobileNumber { get; set; }
        public bool Confirmed { get; set; }
    }
}
