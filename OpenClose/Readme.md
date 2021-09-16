#Open close principle
##Otwarte/zamknięte

Budujemy rozwiązania tak aby było otwarte na rozszerzenie a zamknięte na modyfikacje.
Budujemy klasę do obsługi zapisu faktury. Sama klasa nie wie w jaki sposób będzie się to odbywało.

```c#
public InvoicePersistence(IInvoiceWrite invoiceSaver, Invoice invoice)
```

Do konstruktora wstrzykujemy fakturę (Invoice) oraz wybrany mechanizm do zapisu faktury
(implementację interface IInvoiceWriter).

```c#
            var mongoWriter = new MongoInvoiceWrite();
           // var pdfWriter = new PdfInvoiceWrite();
            var invoice = new Invoice();

            var invoiceWriter = new InvoicePersistence(mongoWriter, invoice);
            invoiceWriter.Save();
```
