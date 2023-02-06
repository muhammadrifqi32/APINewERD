using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APINewErd.Models
{
	public class Employee
	{
		[Key]
		public string? NIK { get; set; }
		public string? FirstName { get; set; }
		public string? LastName { get; set; }
		public string? Phone { get; set; }
		public DateTime BirthDate { get; set; }
		//format yyyy-mm-dd
		public int Salary { get; set; }
		public string? Email { get; set; }
		public Gender Gender { get; set; }
		public Employee? Manager { get; set; }
		[ForeignKey("Manager")]
		public string? Manager_Id { get; set; }
		public Department? Department { get; set; }
		[ForeignKey("Department")]
		public int? Department_Id { get; set; }
		public Account? Account { get; set; }
	}
	public enum Gender
	{
		Male,
		Female
	}
}

