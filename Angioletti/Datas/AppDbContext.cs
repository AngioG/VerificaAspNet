using Microsoft.EntityFrameworkCore;
using Angioletti.Models;

namespace Angioletti.Datas
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base (options)
        {

        }

        public DbSet<Audio> Audio { get; set; }
    }
}
