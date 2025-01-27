namespace Diy_B.Models
{
    public class UserClaimRequest
    {
        public Guid UserId { get; set; }
        public DateTime ClaimDate { get; set; }
        public decimal ClaimAmount { get; set; }
        public string ClaimReason { get; set; } = string.Empty;
    }

}
