using Microsoft.EntityFrameworkCore;
using Hawk.Models;

namespace Hawk.Data 
{
    public class ApplicationDbContext : DbContext
    {
        
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base (options)
        {

        }
        public DbSet<Category> Categories { get; set; }
    }
}