using IndentityExample.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System.Collections.Generic;

namespace IndentityExample.Data
{
	public class StudentContext : IdentityDbContext<Student>
	{
		public StudentContext(DbContextOptions<StudentContext> options): base(options)
		{

		}

		public ISet<Student> Students { get; set; }


	}
}
