using APINewErd.Models;
using APINewErd.Repository.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace APINewErd.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class AccountsController : ControllerBase
	{
		private readonly AccountRepository repository;
		public AccountsController(AccountRepository repository)
		{
			this.repository = repository;
		}

		[AllowAnonymous]
		[HttpPost("Login")]
		public async Task<ActionResult> Login(AccountVM accountVM)
		{
			var login = await repository.Login(accountVM);
			if (login != null)
			{
				return StatusCode(200, new { status = HttpStatusCode.OK, message = "Login Berhasil", Data = login });
			}
			else if (login == "400")
			{
				return StatusCode(400, new { status = HttpStatusCode.NotFound, message = "Password Salah" });
			}
			return StatusCode(404, new { status = HttpStatusCode.NotFound, message = "Login Gagal" });
		}
	}
}
