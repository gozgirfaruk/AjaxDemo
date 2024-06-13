using Microsoft.EntityFrameworkCore;

namespace AjaxDemo.DAL
{
    public class AjaxContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server =DESKTOP-P40Q2KE\\SQLEXPRESS ; Initial Catalog = AjaxDB ; Integrated Security = true;");
        }

        public DbSet<Product> Products { get; set; }
    }
}
