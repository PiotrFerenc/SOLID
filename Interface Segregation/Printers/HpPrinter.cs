using System;

namespace Interface_Segregation.Printers
{
    public class HpPrinter : IPrinter, IFax 
    {
        public void Print()
        {
            Console.WriteLine("Printing ...");
        }

        public void SendFax()
        {
            Console.WriteLine("Sending fax ...");
        }
    }
}