using Microsoft.EntityFrameworkCore;

namespace A_Work_5_API.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options)
            : base(options)
        {

        }
        public DbSet<Item> Items { get; set; } = null!;
    }
}