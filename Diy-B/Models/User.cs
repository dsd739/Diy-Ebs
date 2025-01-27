using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace Diy_B.Models
{
    public class users
    {
        [Key]
        public Guid  user_id { get; set; }
        public long account_no { get; set; }
        public string password { get; set; } = string.Empty;
        public string role { get; set; } = string.Empty;
        public bool is_active { get; set; }
        public DateTime? expiry_date { get; set; }

    }


    public class Claim
    {
        public Guid ClaimId { get; set; }
        public Guid UserId { get; set; }
        public DateTime ClaimDate { get; set; }
        public decimal ClaimAmount { get; set; }
        public string ClaimReason { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
        public Guid? AdminId { get; set; }
        public string? RejectionReason { get; set; }

        public users User { get; set; } = null!;
        public ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();
    }

    public class Master
    {
        public Guid MasterId { get; set; }
        public Guid UserId { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal RemainingAmount { get; set; }

        public users User { get; set; } = null!;
    }

    public class Transaction
    {
        public Guid TransactionId { get; set; }
        public Guid UserId { get; set; }
        public Guid? ClaimId { get; set; }
        public DateTime TransactionDate { get; set; }
        public string TransactionType { get; set; } = string.Empty;
        public string? Remarks { get; set; }

        public users User { get; set; } = null!;
        public Claim? Claim { get; set; }
    }

    public class Notification
    {
        public Guid NotificationId { get; set; }
        public Guid UserId { get; set; }
        public DateTime SentDate { get; set; }
        public string Message { get; set; } = string.Empty;

        public users User { get; set; } = null!;
    }
    public class UserActivity
    {
        public Guid ActivityId { get; set; }
        public Guid UserId { get; set; }
        public DateTime LoginTime { get; set; }
        public DateTime? LogoutTime { get; set; }

        public users User { get; set; } = null!;
    }
}

