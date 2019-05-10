using DPTO.Domain;
using Microsoft.EntityFrameworkCore;

namespace DPTO.Infrastructure
{
    public class DptoContext : DbContext
    {
        public DptoContext(DbContextOptions<DptoContext> options) : base(options)
        {
        }

        public DbSet<Car> Cars { get; set; }
    }
}