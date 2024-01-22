using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Course
{
    class Aluno
    {
        public string Nome;
        public double Nota1;
        public double Nota2;
        public double Nota3;

        public double NotaFinal()
        {
            return Nota1 + Nota2 + Nota3;
        }

        public double NotasRestantes()
        {
            return 60.00 - NotaFinal();
        }

        
    }
}
