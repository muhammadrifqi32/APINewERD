using System.ComponentModel.DataAnnotations.Schema;

namespace APINewErd.Models
{
	public class AccountRole
	{
		[ForeignKey("Role")]
		public int Role_Id { get; set; }
		public Role Role { get; set; }
		[ForeignKey("Account")]	
		
		public string NIK { get; set;}
		public Account Account { get; set; }
	}
}
