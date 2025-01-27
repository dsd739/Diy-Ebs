using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Diy_B.Models
{
    public class Claim
    {
        [Key]
        public Guid ClaimId { get; set; }

        [Required]
        public Guid UserId { get; set; }

        [Required]
        public DateTime ClaimDate { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal ClaimAmount { get; set; }

        [Required]
        [MaxLength(500)]
        public string ClaimReason { get; set; } = string.Empty;

        [Required]
        [MaxLength(50)]
        public string Status { get; set; } = string.Empty;

        public Guid? AdminId { get; set; }

        [MaxLength(500)]
        public string? RejectionReason { get; set; }

        // Navigation Properties
        [ForeignKey("UserId")]
        public User User { get; set; } = null!;

        public ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();
    }
}
