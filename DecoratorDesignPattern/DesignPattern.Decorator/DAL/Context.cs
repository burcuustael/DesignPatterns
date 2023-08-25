using Microsoft.EntityFrameworkCore;

namespace DesignPattern.Decorator.DAL
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-KOJI8U6;initial catalog=DesignPattern11; integrated security=true;");

            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Message> Messages { get; set; }
        public DbSet<Notifier> Notifiers { get; set; }
    }
}
