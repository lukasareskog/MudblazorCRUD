using Microsoft.EntityFrameworkCore;
using MudblazorCRUD.Data;

namespace MudblazorCRUD.Context
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {

        }

        public DbSet<Article> Articles { get; set; }

        public DbSet<Document> Documents { get; set; }
    }
}
