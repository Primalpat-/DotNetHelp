using System.Collections.Generic;

namespace DotNetHelp.Core.Entities
{
    public partial class Item
    {
        public Item()
        {
            Orders = new List<Order>();
        }

        public int ItemID { get; set; }
        public string ItemDesc { get; set; }
        public decimal? ItemPrice { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
