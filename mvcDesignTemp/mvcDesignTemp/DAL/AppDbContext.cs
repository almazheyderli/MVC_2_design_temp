using Microsoft.EntityFrameworkCore;
using mvcDesignTemp.Models;

namespace mvcDesignTemp.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
            
        }
        public DbSet<Services>Services { get; set; }
    }
}
