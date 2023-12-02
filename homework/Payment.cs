using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework
{
    public class Payment
    {

        public int Id { get; set; }
        public double Amount { get; set; }
    }

    public partial class Cash: Payment
    {
        public int Id { get; set; } = 0;

        public double Amount { get; set; }

        public double cashTendered { get; set; }

        public Cash(int id, double amount) {
            Id = id;
            Amount = amount;
        }
    }

    public partial class Check : Payment
    {
        public int Id { get; set; } = 0;

        public double Amount { get; set; }

        public string Name { get; set; }
        public string BankId { get; set; }
        public Check(int id, double amount, string name, string bankId)
        {
            Id = id;
            Amount = amount;
            Name = name;
            BankId = bankId;    
        }

        public bool authorized(bool authorized)
        {
            return authorized;
        }
    }

    public partial class Credit : Payment
    {
        public int Id { get; set; } = 0;

        public double Amount { get; set; }

        public string Name { get; set; }

        public string Type { get; set; }

        public string ExpDate { get; set; }
        public Credit(int id, double amount, string name, string type, string expDate)
        {
            Id = id;
            Amount = amount;
            Name = name;
            Type = type;
            this.ExpDate = expDate;
        }

        public bool authorized(bool authorized)
        {
            return authorized;
        }
    }
}
