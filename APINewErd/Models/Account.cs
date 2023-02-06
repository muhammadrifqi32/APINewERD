using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace APINewErd.Models
{
	public class Account
	{
		[Key, ForeignKey("Employee")]
		public string? NIK { get; set; }
		public Employee Employee { get; set; }
		public string? Password { get; set; }
		public virtual ICollection<AccountRole> AccountRoles { get; set; }
	}
}
