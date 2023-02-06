using APINewErd.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace APINewErd.Context
{
	public class MyContext : DbContext
	{
		public MyContext(DbContextOptions<MyContext> options) : base(options)
		{

		}
		public DbSet<Employee> Employees { get; set; }
		public DbSet<Department> Departments { get; set; }
		public DbSet<Account> Accounts { get; set; }
		public DbSet<Role> Roles { get; set; }
		public DbSet<AccountRole> AccountRoles { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<AccountRole>()
				.HasKey(ar => new { ar.NIK, ar.Role_Id });
			modelBuilder.Entity<AccountRole>()
			   .HasOne(a => a.Account)
			   .WithMany(b => b.AccountRoles)
			   .HasForeignKey(a => a.NIK);
			modelBuilder.Entity<AccountRole>()
				.HasOne(a => a.Role)
				.WithMany(b => b.AccountRoles)
				.HasForeignKey(a => a.Role_Id);
		}
	}
}
