using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework
{
    internal class OrderDetails
    {
        public string quality { get; set; }
        public Order order { get; set; }

        public List<Item> Items { get; set; }
        public OrderDetails(List<Item> items)
        {
            Items = items;
        }
        public float calcSubTotal()
        {
            return 0;
        }

        public float calcTax()
        {
            return 0;
        }

        public float calcWeight()
        {
            return 0;
        }

    }
}
