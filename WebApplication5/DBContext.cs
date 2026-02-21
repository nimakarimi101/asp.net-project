using Microsoft.EntityFrameworkCore;
using WebApplication5.Models;

namespace WebApplication5
{
    public class DBContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        

        public DBContext(DbContextOptions<DBContext> options) : base(options)
        {
        }
    }
}