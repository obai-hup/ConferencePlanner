using Microsoft.EntityFrameworkCore;

namespace BackEnd.Models
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options) { }
            public DbSet<Speaker> Speakers {get; set;}
        
    }
}
