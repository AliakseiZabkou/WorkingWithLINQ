using Microsoft.EntityFrameworkCore;
namespace Packt.CS7
{
    // управление подключением к БД
    public class Northwind : DbContext
    {
        // эти свойства соотносятся с таблицами в базе
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        protected override void OnConfiguring(
        DbContextOptionsBuilder optionsBuilder)
        {
             optionsBuilder.UseSqlServer(
                 @"Data Source=(localdb)\mssqllocaldb;" +
                 "Initial Catalog=Northwind;" +
                 "Integrated Security=true;" +
                 "MultipleActiveResultSets=true;");
        }
    }
}
