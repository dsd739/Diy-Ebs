using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Diy_B.Models
{
    public class User
    {
        public Guid UserId { get; set; }
        public long AccountNo { get; set; }
        public string Password { get; set; } = string.Empty;
        public string Role { get; set; } = string.Empty;
        public bool IsActive { get; set; }
        public DateTime? ExpiryDate { get; set; }

        public string Username { get; set; } = string.Empty;
        public string PasswordHash { get; set; } = string.Empty;

        public ICollection<Claim> Claims { get; set; } = new List<Claim>();
        public ICollection<Master> Masters { get; set; } = new List<Master>();
        public ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();
        public ICollection<Notification> Notifications { get; set; } = new List<Notification>();
        public ICollection<UserActivity> UserActivities { get; set; } = new List<UserActivity>();
    }

   

}

