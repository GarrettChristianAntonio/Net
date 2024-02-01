using Microsoft.AspNetCore.Identity;

namespace IndentityExample.Models
{
	public class Student : IdentityUser
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
	}
}
