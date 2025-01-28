using Diy_B.Data;
using Diy_B.Models;
using System;
using System.Threading.Tasks;

public class ClaimService : IClaimService
{
    private readonly AppDbContext _context;

    public ClaimService(AppDbContext context)
    {
        _context = context;
    }

    public async Task<Guid> SubmitClaimAsync(UserClaimRequest request)
    {
        var claim = new Claim
        {
            
            UserId = request.UserId,
            ClaimDate = request.ClaimDate,
            ClaimAmount = request.ClaimAmount,
            ClaimReason = request.ClaimReason,
            
        };

        _context.Claims.Add(claim);
        await _context.SaveChangesAsync();

        return claim.ClaimId;
    }
}
