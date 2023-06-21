using Microsoft.EntityFrameworkCore;

namespace InspimoMediatorDesignPattern.DAL
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=SAADET\\SQLEXPRESS01;initial catalog=DbİnspimoMediatorPattern;integrated security=true");
        }
        public DbSet<Product> Products { get; set; }
    }
}
