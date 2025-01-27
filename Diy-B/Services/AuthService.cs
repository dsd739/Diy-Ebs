using Diy_B.Data;
using Diy_B.Models;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;
using System.Text;

namespace Diy_B.Services
{
    public class AuthService
    {
		private readonly AppDbContext _context;

		public AuthService(AppDbContext context)
		{
			_context = context;
		}

		public async Task<User?> AuthenticateAsync(string username, string password)
		{
			var user = await _context.Users.FirstOrDefaultAsync(u => u.Username == username);
			if (user == null || !VerifyPassword(password, user.PasswordHash))
				return null;

			return user;
		}

		public static string HashPassword(string password)
		{
			using var sha256 = SHA256.Create();
			return Convert.ToBase64String(sha256.ComputeHash(Encoding.UTF8.GetBytes(password)));
		}

		private static bool VerifyPassword(string password, string passwordHash)
		{
			return HashPassword(password) == passwordHash;
		}

        internal async Task RegisterUserAsync(string username, string password)
        {
            throw new NotImplementedException();
        }
    }
}
