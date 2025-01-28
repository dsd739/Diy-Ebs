using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Diy_B.Models
{
    public class UserActivity
    {

        public Guid activity_id { get; set; }
        public Guid user_id { get; set; }
        public DateTime login_time { get; set; }
        public DateTime? logout_time { get; set; }

        public User User { get; set; } = null!;
        
    }
}
