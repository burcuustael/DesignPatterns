using Microsoft.EntityFrameworkCore;

namespace DesignPattern.ChainOfResponsibilty.DAL
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-KOJI8U6;initial catalog=DesignPattern1; integrated security=true;");

            base.OnConfiguring(optionsBuilder); 
        }

        public DbSet<CustomerProcess> CustomerProcesses { get; set; }
    }
}
