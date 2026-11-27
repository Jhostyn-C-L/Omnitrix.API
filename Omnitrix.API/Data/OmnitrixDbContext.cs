using Microsoft.EntityFrameworkCore;
using Omnitrix.API.Models;

namespace Omnitrix.API.Data
{
    public class OmnitrixDbContext : DbContext
    {
        public OmnitrixDbContext(DbContextOptions<OmnitrixDbContext> options) : base(options) { }
        public DbSet<Alien> Aliens { get; set; } = null!;
    }
}
