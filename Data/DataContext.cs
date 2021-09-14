using MonitoringPortal.API.Models;
using Microsoft.EntityFrameworkCore;

namespace MonitoringPortal.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<DbValues> DbValues { get; set; }
        public DbSet<DbUser> DbUsers { get; set; }
    }
}