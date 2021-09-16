using System;
using Domain;

namespace OpenClose.InvoiceWriters
{
    public class MongoInvoiceWrite : IInvoiceWrite
    {
        public void Save(Invoice invoice)
        {
            Console.WriteLine($"Invoice {invoice.Number} has been saved in the database.");
        }
    }
}