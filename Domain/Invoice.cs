using System;
using System.Collections.Generic;

namespace Domain
{
    public class Invoice
    {
        public Invoice()
        {
            Number = Guid.NewGuid().ToString();
        }

        public string Number { get; set; }
        public Seller Seller { get; set; }
        public Buyer Buyer { get; set; }
        public List<Item> Items { get; set; }
        public DateTime DateOfPayment { get; set; }
    }
}