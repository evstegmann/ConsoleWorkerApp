﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Course.Device
{
    class Printer : Device, IPrinter
    {
        public override void ProcessDoc(string document)
        {
            Console.WriteLine("Print processing: " + document);
        }

        public void Print(string document)
        {
            Console.WriteLine("Printer print result: " + document);
        }
    }
}
