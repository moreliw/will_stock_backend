using Microsoft.EntityFrameworkCore;
using will_stock_backend.Models;

namespace will_stock_backend.Data
{
    public class DataContext : DbContext
    {
        public DataContext (DbContextOptions<DataContext> options)
            : base(options)
        {
        }

        public DbSet<ProductModel> ProductModel { get; set; } = default!;
    }
}
