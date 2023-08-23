using Microsoft.EntityFrameworkCore;

namespace DesignPattern.Mediator.DAL
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-KOJI8U6;initial catalog=DesignPattern8; integrated security=true;");

            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Product>? Products { get; set; }
         
    
    }
}
