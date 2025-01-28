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

<<<<<<< HEAD
		public async Task<User?> AuthenticateAsync(string Username, string password)
		{
			var user = await _context.Users.FirstOrDefaultAsync(u => u.Username == Username);
			if (user == null || !VerifyPassword(password, user.PasswordHash))
=======
		public async Task<users?> AuthenticateAsync(Guid username, string password)
		{
			var user = await _context.users.FirstOrDefaultAsync(u => u.user_id == username);
			if (user == null || !VerifyPassword(password, user.password))
>>>>>>> 27a5575b947e9870a3cd195f9e97c75cb9250a5f
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

            return password== passwordHash;

        
    }
}
