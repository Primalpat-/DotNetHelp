using DotNetHelp.Core.Entities;
using System.Data.Entity.ModelConfiguration;

namespace DotNetHelp.Data.Models.Mapping
{
    public class OrderMap : EntityTypeConfiguration<Order>
    {
        public OrderMap()
        {
            // Primary Key
            this.HasKey(t => t.OrderID);

            // Properties
            this.Property(t => t.RequestedBy)
                .HasMaxLength(150);

            this.Property(t => t.TimeOfBooking)
                .HasMaxLength(30);

            this.Property(t => t.Host)
                .HasMaxLength(150);

            this.Property(t => t.Attendees)
                .HasMaxLength(255);

            this.Property(t => t.Room)
                .HasMaxLength(80);

            this.Property(t => t.Team)
                .HasMaxLength(150);

            this.Property(t => t.FileNo)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("Orders");
            this.Property(t => t.OrderID).HasColumnName("OrderID");
            this.Property(t => t.PurchaseOrderID).HasColumnName("PurchaseOrderID");
            this.Property(t => t.RequestedBy).HasColumnName("RequestedBy");
            this.Property(t => t.DateRequested).HasColumnName("DateRequested");
            this.Property(t => t.DateOfBooking).HasColumnName("DateOfBooking");
            this.Property(t => t.TimeOfBooking).HasColumnName("TimeOfBooking");
            this.Property(t => t.Host).HasColumnName("Host");
            this.Property(t => t.Attendees).HasColumnName("Attendees");
            this.Property(t => t.Room).HasColumnName("Room");
            this.Property(t => t.Team).HasColumnName("Team");
            this.Property(t => t.FileNo).HasColumnName("FileNo");
            this.Property(t => t.Comments).HasColumnName("Comments");
            this.Property(t => t.itemID).HasColumnName("itemID");
            this.Property(t => t.ItemQuantity).HasColumnName("ItemQuantity");

            // Relationships
            this.HasOptional(t => t.Item)
                .WithMany(t => t.Orders)
                .HasForeignKey(d => d.itemID);

        }
    }
}
