using Domain;

namespace OpenClose
{
    public class InvoicePersistence
    {
        private readonly IInvoiceWrite _invoiceSaver;
        private readonly Invoice _invoice;
        
        public InvoicePersistence(IInvoiceWrite invoiceSaver, Invoice invoice)
        {
            _invoiceSaver = invoiceSaver;
            _invoice = invoice;
        }

        public void Save()
        {
            _invoiceSaver.Save(_invoice);
        }
    }
}