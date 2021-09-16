using System.Linq;
using Domain;

namespace SingleResponsibility_Principle
{
    public class InvoiceManager
    {
        private Invoice Invoice { get; set; }

        public InvoiceManager(Invoice invoice)
        {
            Invoice = invoice;
        }

        public double CountTotal()
        {
            var total = Invoice.Items.Sum(x => (x.NetPrice * x.Count * (x.Tax + 1)));

            return total;
        }
    }
}