using System;
using System.Collections.Generic;

namespace DotNetHelp.Data.Models
{
    public partial class Item
    {
        public Item()
        {
            this.Orders = new List<Order>();
        }

        public int ItemID { get; set; }
        public string ItemDesc { get; set; }
        public Nullable<decimal> ItemPrice { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
