using Diy_B.Models;
using Diy_B.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Diy_B.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClaimController : ControllerBase
    {
        private readonly IClaimService _claimService;

        public ClaimController(IClaimService claimService)
        {
            _claimService = claimService;
        }

        // GET: api/claim
        [HttpGet]
        public async Task<IActionResult> GetAllClaims()
        {
            var claims = await _claimService.GetAllClaimsAsync();
            return Ok(claims);
        }

        // GET: api/claim/{id}
        [HttpGet("{id:guid}")]
        public async Task<IActionResult> GetClaimById(Guid id)
        {
            var claim = await _claimService.GetClaimByIdAsync(id);
            if (claim == null)
                return NotFound($"Claim with ID {id} not found.");

            return Ok(claim);
        }

        // POST: api/claim
        [HttpPost]
        public async Task<IActionResult> CreateClaim([FromBody] Claim request)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var claimId = await _claimService.CreateClaimAsync(request);
            return CreatedAtAction(nameof(GetClaimById), new { id = claimId }, new { claimId });
        }

       
    }
    public interface IClaimService
    {
        Task<IEnumerable<Claim>> GetAllClaimsAsync();
        Task<Claim?> GetClaimByIdAsync(Guid id);
        Task<Guid> CreateClaimAsync(Claim request);
    }


   
}
