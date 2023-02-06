using APINewErd.Context;
using APINewErd.Models;

namespace APINewErd.Repository.Data
{
	public class DepartmentRepository : GeneralRepository<MyContext, Department, int>
	{
		public DepartmentRepository(MyContext context) : base(context)
		{

		}
	}
}
