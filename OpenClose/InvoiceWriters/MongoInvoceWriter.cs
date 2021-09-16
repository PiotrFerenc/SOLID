using System;
using Domain;

namespace OpenClose.InvoiceWriters
{
    public class PdfInvoiceWrite : IInvoiceWrite
    {
        public void Save(Invoice invoice)
        {
            Console.WriteLine($"Invoice {invoice.Number} save as PDF.");
        }
    }
}