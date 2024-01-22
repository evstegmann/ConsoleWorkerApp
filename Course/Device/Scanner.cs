using System;
using System.Collections.Generic;
using System.Text;

namespace Course.Device
{
    class Scanner : Device, IScanner
    {
        public override void ProcessDoc(string document)
        {
            Console.WriteLine("Scan processing: " + document);

        }

        public string Scan()
        {
            return "Scanner scan result";
        }
    }
}

