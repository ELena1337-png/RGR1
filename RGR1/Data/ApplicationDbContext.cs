using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace RGR1.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Production> Productions { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
    }
}
