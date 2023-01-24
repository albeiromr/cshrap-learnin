using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aplicacion1.data_types
{
    internal class Doubles
    {
        public static void PrintDoubles()
        {
            #region tipo de dato flotantes

            //tipos de datos de punto flotante
            //reference  https://www.youtube.com/watch?v=7OcIQEO9psc&ab_channel=ElCaminoDev
            //reference 2 https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/floating-point-numeric-types#code-try-1

            //decimal: muchísima mas precisión, 28-29 digits, menor rendimiento, numero con base 10, Literal m, 128bits
            decimal decimaluno = 2.1m;
            Console.WriteLine(decimaluno);

            //double: presición intermedia pero mas rendimiento, ~15-17 digits, numero con base 2, literal D, 64bits
            double doubleuno = 3.569536D;
            Console.WriteLine(doubleuno);

            //float: menor presición que el double, ~6-9 digits, mas rendimiento, literal F, 32bits
            float floatuno = 5.8890F;
            Console.WriteLine(floatuno);

            #endregion
        }
    }
}
