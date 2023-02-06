using APINewErd.Base;
using APINewErd.Models;
using APINewErd.Repository.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APINewErd.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class RolesController : BaseController<Role, RoleRepository, int>
	{
		public RolesController(RoleRepository roleRepository) : base(roleRepository)
		{

		}
	}
}
