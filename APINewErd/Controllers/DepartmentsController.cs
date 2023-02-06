using APINewErd.Base;
using APINewErd.Models;
using APINewErd.Repository.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APINewErd.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class DepartmentsController : BaseController<Department, DepartmentRepository, int>
	{
		public DepartmentsController(DepartmentRepository departmentRepository) : base(departmentRepository)
		{

		}
	}
}
