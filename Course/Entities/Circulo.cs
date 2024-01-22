using System;
using System.Collections.Generic;
using System.Text;

namespace Course.Entities
{
    class Circulo : Forma
    {
        public int Numero { get; set; }

       
        

        public override void Desenhar()
        {
            Console.WriteLine("Desenhar Círculo");
        }

        public void PintarCirculo()
        {
            Console.WriteLine("Pintando o Círculo");
        }
    }
}
