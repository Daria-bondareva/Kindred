using Kindred.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Kindred.Infrastructure.Context
{
    public class KindredDbContext:DbContext
    {
        public KindredDbContext(DbContextOptions<KindredDbContext> options): base(options) { }

        public DbSet<Event> Events { get; set; } 
    }
}
