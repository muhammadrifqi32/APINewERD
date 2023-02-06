using APINewErd.Base;
using APINewErd.Models;
using APINewErd.Repository.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APINewErd.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class EmployeesController : BaseController<Employee, EmployeeRepository, string>
	{
		public EmployeesController(EmployeeRepository employeeRepository) : base(employeeRepository)
		{

		}
	}
}
