using Diy_B.Models;
using System;
using System.Threading.Tasks;

public interface IClaimService
{
    Task<Guid> SubmitClaimAsync(UserClaimRequest request);
}
