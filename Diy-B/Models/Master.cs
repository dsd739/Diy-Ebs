using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Diy_B.Models
{
    public class Master
    {
        public Guid MasterId { get; set; }
        public Guid UserId { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal RemainingAmount { get; set; }

        public User User { get; set; } = null!;
    }
}
