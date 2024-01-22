using System;
using System.Collections.Generic;
using System.Text;

namespace Course.Device
{
    class ComboDevice : Device, IPrinter, IScanner
    {
        public override void ProcessDoc(string document)
        {
            Console.WriteLine("ComboDevice processing: " + document);

        }

        public string Scan()
        {
            return "ComboDevice Scan result";
        }

        public void Print(string document)
        {
            Console.WriteLine("ComboDevice print " + document);
        }
    }
}
