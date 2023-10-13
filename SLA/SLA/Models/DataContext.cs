using Microsoft.EntityFrameworkCore;

namespace SLA.Models
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options):base(options) 
        {
                
        }
        public DbSet<SLA> SLAs { get; set; }
    }
}
