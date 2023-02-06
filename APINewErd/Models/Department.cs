using System.ComponentModel.DataAnnotations.Schema;

namespace APINewErd.Models
{
	public class Department
	{
		public int Id { get; set; }
		public string? Name { get; set; }
		public Employee Employee { get; set; }
		[ForeignKey("Employee")]
		public string? Manager_Id { get; set; }
	}
}
