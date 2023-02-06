using APINewErd.Context;
using APINewErd.Models;

namespace APINewErd.Repository.Data
{
	public class RoleRepository : GeneralRepository<MyContext, Role, int>
	{
		public RoleRepository(MyContext context) : base(context)
		{

		}
	}
}
