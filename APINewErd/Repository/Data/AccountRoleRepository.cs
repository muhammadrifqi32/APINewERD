using APINewErd.Context;
using APINewErd.Models;

namespace APINewErd.Repository.Data
{
	public class AccountRoleRepository : GeneralRepository<MyContext, AccountRole, int>
	{
		public AccountRoleRepository(MyContext context) : base(context)
		{

		}
	}
}
