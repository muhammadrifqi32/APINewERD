using APINewErd.Base;
using APINewErd.Models;
using APINewErd.Repository.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APINewErd.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class AccountRolesController : BaseController<AccountRole, AccountRoleRepository, int>
	{
		public AccountRolesController(AccountRoleRepository accountRoleRepository) : base(accountRoleRepository)
		{

		}
	}
}
