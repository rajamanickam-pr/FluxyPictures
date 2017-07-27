using Fluxy.Data.Model.Common;
using System;

namespace Fluxy.Data.EntityModels.Users
{
    public class User:Entity<long>
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public string EmailToRevalidate { get; set; }
        public string Password { get; set; }
        public string PasswordSalt { get; set; }
        public int FailedLoginAttempts { get; set; }
        public bool Active { get; set; }
        public bool Deleted { get; set; }
        public string SystemName { get; set; }
        public string LastIpAddress { get; set; }
        public DateTime? LastLoginDateUtc { get; set; }
    }
}
