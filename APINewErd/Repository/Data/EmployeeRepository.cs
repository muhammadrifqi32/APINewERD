using APINewErd.Context;
using APINewErd.Models;

namespace APINewErd.Repository.Data
{
	public class EmployeeRepository : GeneralRepository<MyContext, Employee, string>
	{
		public EmployeeRepository(MyContext context) : base(context)
		{

		}
	}
}
