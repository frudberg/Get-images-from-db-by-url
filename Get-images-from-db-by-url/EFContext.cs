using Microsoft.EntityFrameworkCore;
using Get_images_from_db_by_url.Models;

namespace Get_images_from_db_by_url
{
    public class EFContext : DbContext
    {
        public DbSet<Image> Images { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlite("Data Source=database.db");
    }
}
