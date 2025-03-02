using Microsoft.EntityFrameworkCore;
using employeedb.Models;  

namespace employeedb.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Employee> Employees { get; set; }  // This should now work
    }
}
