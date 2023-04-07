using CompanySln.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CompanySln.DataContext
{
    public class CompanyContext:IdentityDbContext<Staff>
    {
        public CompanyContext(DbContextOptions options):base(options) { }
        

        public DbSet<Company> Companies { get; set; }
        public DbSet<Department> Departments { get; set; }

    }
}
