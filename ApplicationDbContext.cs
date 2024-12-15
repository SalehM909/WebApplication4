using Microsoft.EntityFrameworkCore;
using WebApplication4.Controllers;

namespace WebApplication4
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
               : base(options)
        {

        }
        public DbSet<User> users { get; set; }
        public DbSet<Product> products { get; set; }    
    }
}
