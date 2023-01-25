using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aplicacion1.constants
{
    internal class Constants
    {
        public static void PrintConstants()
        {
            //las constantes se declaran con la palabra cont seguido del tipo de dato
            //solo se pueden contruir constantes con los tipos de datos primitivos,
            //no se pueden construir con tipos de datos personalizados
            const int a = 42;
            Console.WriteLine(a);

        }
    }
}
