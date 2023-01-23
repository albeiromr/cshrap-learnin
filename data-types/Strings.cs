using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aplicacion1.data_types
{
    internal class Strings
    {
        public static void PrintStrings()
        {
            #region concatenaciones de strings

            byte años = 18;
            string meazure = " edad";

            //concatenación con el simbolo mas
            Console.WriteLine("tienes " + años + " de" + meazure);

            //concatenación con interpolación
            Console.WriteLine($"Tienes una edad de {años} años");

            #endregion
        }
    }
}
