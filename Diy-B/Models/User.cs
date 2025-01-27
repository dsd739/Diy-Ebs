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

        public ICollection<Claim> Claims { get; set; } = new List<Claim>();
        public ICollection<Master> Masters { get; set; } = new List<Master>();
        public ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();
        public ICollection<Notification> Notifications { get; set; } = new List<Notification>();
        public ICollection<UserActivity> UserActivities { get; set; } = new List<UserActivity>();
    }

    public class Master
    {
        public Guid MasterId { get; set; }
        public Guid UserId { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal RemainingAmount { get; set; }

        public User User { get; set; } = null!;
    }

    public class Transaction
    {
        public Guid TransactionId { get; set; }
        public Guid UserId { get; set; }
        public Guid? ClaimId { get; set; }
        public DateTime TransactionDate { get; set; }
        public string TransactionType { get; set; } = string.Empty;
        public string? Remarks { get; set; }

        public User User { get; set; } = null!;
        public Claim? Claim { get; set; }
    }

    public class Notification
    {
        public Guid NotificationId { get; set; }
        public Guid UserId { get; set; }
        public DateTime SentDate { get; set; }
        public string Message { get; set; } = string.Empty;

        public User User { get; set; } = null!;
    }
    public class UserActivity
    {
        public Guid ActivityId { get; set; }
        public Guid UserId { get; set; }
        public DateTime LoginTime { get; set; }
        public DateTime? LogoutTime { get; set; }

        public User User { get; set; } = null!;
    }
}

