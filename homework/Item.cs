using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework
{
    internal class Item
    {
        public double shippingWeight {get;set;}

        public string description { get;set;}

        public Item(double shippingWeight, string description)
        {
            this.shippingWeight = shippingWeight;
            this.description = description; 
        }
        public float getPriceForQuantity()
        {
            return 0;
        }

        public float getTax()
        {
            return 0;
        }

        public bool inStock()
        {
            return false;
        }

    }
}
