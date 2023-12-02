using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework
{
    internal class Order
    {
        public int Id { get; set; }
        public string Date { get; set; }
        public string Status { get; set; }

        public OrderDetails Details { get; set; }
        public Customer Customer { get; set; }
        public Order(OrderDetails orderDetails, Customer customer) {
            this.Customer = customer;
            this.Details = orderDetails;
        }

        public float calcSubTotal() {
            return 0;
        }

        public float calcTotal()
        {
            return 0;
        }

        public float calcTax()
        {
            return 0;
        }

        public float calcTotalWeight()
        {
            return 0;
        }
    }
}
