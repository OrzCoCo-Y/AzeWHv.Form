using Microsoft.EntityFrameworkCore;

namespace AzeWHV.Data
{
    public class AzeDataContext : DbContext
    {

        public AzeDataContext(DbContextOptions<AzeDataContext> options)
    : base(options)
        {
        }

        public DbSet<CustomInfo> CustomInfos { get; set; }



    }
}
