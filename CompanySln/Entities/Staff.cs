using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace CompanySln.Entities
{
    public class Staff:IdentityUser
    {
        [Key]
        public string StaffId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public DateTimeOffset EmploymentDate { get; set; }
        public long DepartmentId { get; set; }
    }
}
