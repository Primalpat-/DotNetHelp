using System;
using System.Collections.Generic;

namespace DotNetHelp.Data.Models
{
    public partial class Order
    {
        public int OrderID { get; set; }
        public Nullable<int> PurchaseOrderID { get; set; }
        public string RequestedBy { get; set; }
        public Nullable<System.DateTime> DateRequested { get; set; }
        public Nullable<System.DateTime> DateOfBooking { get; set; }
        public string TimeOfBooking { get; set; }
        public string Host { get; set; }
        public string Attendees { get; set; }
        public string Room { get; set; }
        public string Team { get; set; }
        public string FileNo { get; set; }
        public string Comments { get; set; }
        public Nullable<int> itemID { get; set; }
        public Nullable<int> ItemQuantity { get; set; }
        public virtual Item Item { get; set; }
    }
}
