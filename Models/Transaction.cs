using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalAccounts.Models
{
    public class Transaction
    {
        public int TransactionId { get; set; }
        public double Amount { get; set; }
        public DateTime TransDate { get; set; }
        public string Description { get; set; }

        public Category Category { get; set; }

    }
}
