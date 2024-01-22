using System;
using System.Collections.Generic;
using System.Text;

namespace Course
{
    class ConversorDeMoeda
    {
        public static double CotacaoDolar;
        public static double ValorDolar;

        public static double ConverterDolar()
        {
            return ((ValorDolar * CotacaoDolar) * 0.06) + ValorDolar * CotacaoDolar;
        }


    }
}
