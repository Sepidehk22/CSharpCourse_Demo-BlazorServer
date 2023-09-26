using BlazorApp11.Data;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp11.Context
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options)
            : base(options)
        {

        }

        public DbSet<Employee> Employees { get; set; }

    }
}
