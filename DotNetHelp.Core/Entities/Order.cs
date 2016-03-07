using System;

namespace DotNetHelp.Core.Entities
{
    public partial class Order
    {
        public int OrderID { get; set; }
        public int? PurchaseOrderID { get; set; }
        public string RequestedBy { get; set; }
        public DateTime? DateRequested { get; set; }
        public DateTime? DateOfBooking { get; set; }
        public string TimeOfBooking { get; set; }
        public string Host { get; set; }
        public string Attendees { get; set; }
        public string Room { get; set; }
        public string Team { get; set; }
        public string FileNo { get; set; }
        public string Comments { get; set; }
        public int? itemID { get; set; }
        public int? ItemQuantity { get; set; }
        public virtual Item Item { get; set; }
    }
}
