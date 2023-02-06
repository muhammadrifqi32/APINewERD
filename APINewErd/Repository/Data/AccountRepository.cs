using APINewErd.Context;
using APINewErd.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.CodeDom.Compiler;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace APINewErd.Repository.Data
{
	public class AccountRepository
	{
		private readonly MyContext context;
		private IConfiguration _config;
		public AccountRepository(MyContext context, IConfiguration config)
		{
			this.context = context;
			_config = config;
		}


		public async Task<string> Login(AccountVM accountVM)
		{
			var user = await context.AccountRoles
				.Where(ar => ar.Account.Employee.Email == accountVM.Email
				&& ar.Account.Password == accountVM.Password)
				.Include(r => r.Role).Include(e => e.Account.Employee)
				.FirstOrDefaultAsync();

			if (accountVM.Password == null)
			{
				return "400";
			}
			else if (user != null)
			{
				var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["JWT:Key"]));
				var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

				var claims = new[] {
					new Claim("Email", user.Account.Employee.Email),
					new Claim("roles", user.Role.Name)
				   };

				var token = new JwtSecurityToken(_config["JWT:Issuer"],
					_config["JWT:Audience"],
					claims,
					expires: DateTime.Now.AddMinutes(15),
					signingCredentials: credentials);

				var jwt = new JwtSecurityTokenHandler().WriteToken(token);
				return jwt;
			}
			else
			{
				return "404";
			}
		}

		//public string Generate(AccountVM accountVM)
		//{
		//	var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["JWT:Key"]));
		//	var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

		//	var claims = new[]
		//	{
		//		new Claim(ClaimTypes.Email, account.Employee.Email)
		//	};

		//	var token = new JwtSecurityToken(_config["JWT:Issuer"],
		//		_config["JWT:Audience"],
		//		claims,
		//		expires: DateTime.Now.AddMinutes(15),
		//		signingCredentials: credentials);

		//	return new JwtSecurityTokenHandler().WriteToken(token);
		//}

		//public async Task<Account> Authenticate(AccountVM accountVM)
		//{
		//	var currentUser = await context.Accounts.FirstOrDefaultAsync(
		//		a => a.Employee.Email.ToLower() == account.Employee.Email.ToLower()
		//		&&
		//		a.Password == account.Password);
		//	if (currentUser != null)
		//	{
		//		return currentUser;
		//	}
		//	return null;
		//}
	}
}
