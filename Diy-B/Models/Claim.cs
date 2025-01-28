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

        [ForeignKey("user_id")]
        [Required]
        public Guid UserId { get; set; }

       
        public DateTime ClaimDate { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal ClaimAmount { get; set; }

        [Required]
        [MaxLength(500)]
        public string ClaimReason { get; set; } = string.Empty;

       


        
        
        

     
    }
}
