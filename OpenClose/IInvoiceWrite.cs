using Domain;

namespace OpenClose
{
    public interface IInvoiceWrite
    {
        void Save(Invoice invoice);
    }
}