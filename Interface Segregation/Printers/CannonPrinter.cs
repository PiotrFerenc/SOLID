using System;

namespace Interface_Segregation.Printers
{
    public class CannonPrinter : IPrinter, IScanner
    {
        public void Print()
        {
            Console.WriteLine("Printing ...");
        }

        public void Scan()
        {
            Console.WriteLine("Scanning ...");
        }
    }
}