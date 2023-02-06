namespace APINewErd.Models
{
	public class Role
	{
		public int Id { get; set; }
		public string? Name { get; set; }
		public virtual ICollection<AccountRole>	AccountRoles { get; set; }
	}
}
