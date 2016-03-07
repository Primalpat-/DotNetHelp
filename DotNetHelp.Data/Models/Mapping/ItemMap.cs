using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace DotNetHelp.Data.Models.Mapping
{
    public class ItemMap : EntityTypeConfiguration<Item>
    {
        public ItemMap()
        {
            // Primary Key
            this.HasKey(t => t.ItemID);

            // Properties
            // Table & Column Mappings
            this.ToTable("Items");
            this.Property(t => t.ItemID).HasColumnName("ItemID");
            this.Property(t => t.ItemDesc).HasColumnName("ItemDesc");
            this.Property(t => t.ItemPrice).HasColumnName("ItemPrice");
        }
    }
}
