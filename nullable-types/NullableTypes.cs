using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aplicacion1.nullable_types
{
    internal class NullableTypes
    {
        public static void PrintNullableTypes()
        {
            #region nullable types;

            //los tipos de datos como strings o arrays pueden inicializarse en nulo,
            //esto por que no almacenan el valor de la variable sino la dirección en
            //memoria donde se encuentra el valor. Sin embargo, otros tipos de datos
            //no se pueden inicializar en nulo, por lo cual se debe usar un Nullable<t>
            //para poder inicializarlos en nulo.

            string myName = null;
            Console.WriteLine(myName);

            Nullable<int> myAge = null;
            Console.WriteLine(myAge);

            Nullable<decimal> myDecimal = null;
            Console.WriteLine(myDecimal);

            //tambíén se puede usar la sintaxis abreviada la cual es la siguiente

            string? myString = null;
            Console.WriteLine(myString);

            int? myInt = null;
            Console.WriteLine(myInt);

            //como se comprueba si un valor que puede ser nullo tiene o no tiene un valor?
            //se usa la propiedad HasValue y Value de la siguiente manera

            double? saldoDeCuenta = null;

            //saldoDeCuenta = 2.56956;

            if (saldoDeCuenta.HasValue)
            {
                Console.WriteLine(saldoDeCuenta.Value);
            }

            #endregion

        }
    }
}
