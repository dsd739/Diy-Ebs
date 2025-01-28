using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Diy_B.Models
{
    public class Notification
    {
        
        public Guid NotificationId { get; set; }
        public Guid UserId { get; set; }
        public Guid ClaimId { get; set; }
        public DateTime SentDate { get; set; }
        public string Message { get; set; } = string.Empty;

        
    }
}
