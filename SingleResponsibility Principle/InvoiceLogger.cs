using System;
using Domain;

namespace SingleResponsibility_Principle
{
    public class InvoiceLogger
    {
        private Invoice _invoice;

        public InvoiceLogger(Invoice invoice)
        {
            _invoice = invoice;
        }

        public void Display()
        {
            Console.WriteLine("Kupujący:");
            Console.WriteLine(_invoice.Buyer.Name.FirstName);
            
            Console.WriteLine("Sprzedawca:");
            Console.WriteLine(_invoice.Seller.Name.FirstName);

            _invoice.Items.ForEach(item => Console.WriteLine($"Nazwa: {item.Name}"));

        }
    }
}