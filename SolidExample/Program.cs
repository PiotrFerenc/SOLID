using System;
using Domain;
using OpenClose;
using OpenClose.InvoiceWriters;

namespace SolidExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var mongoWriter = new MongoInvoiceWrite();
            var pdfWriter = new PdfInvoiceWrite();
            var invoice = new Invoice();

            var invoiceWriter = new InvoicePersistence(pdfWriter, invoice);
            invoiceWriter.Save();
            
        }
    }
}