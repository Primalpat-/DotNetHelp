using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using DotNetHelp.Data.Models.Mapping;

namespace DotNetHelp.Data.Models
{
    public partial class DotNetHelpContext : DbContext
    {
        static DotNetHelpContext()
        {
            Database.SetInitializer<DotNetHelpContext>(null);
        }

        public DotNetHelpContext()
            : base("Name=DotNetHelpContext")
        {
        }

        public DbSet<Item> Items { get; set; }
        public DbSet<Order> Orders { get; set; }
        
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ItemMap());
            modelBuilder.Configurations.Add(new OrderMap());
        }
    }
}
