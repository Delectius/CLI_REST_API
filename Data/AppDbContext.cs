using CLI_REST_API.Models;
using Microsoft.EntityFrameworkCore;

namespace CLI_REST_API.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Command> Commands => Set<Command>();
    }
}