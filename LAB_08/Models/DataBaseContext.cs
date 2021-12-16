using Microsoft.EntityFrameworkCore;

namespace LAB_08.Models
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> options)
            : base(options)
        {
        }

        public DbSet<Pet> Pets { get; set; } = null!;
    }
}