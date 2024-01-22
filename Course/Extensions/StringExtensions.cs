using System;
using System.Collections.Generic;
using System.Text;

namespace System
{
    static class StringExtensions
    {
       public static string Cut(this String thisObj, int count)
        {
            return thisObj.Substring(0, count);

        }

    }

}
