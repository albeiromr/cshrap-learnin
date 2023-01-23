using System;
using aplicacion1.data_types;

namespace aplicacion1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Integers.PrintIntegers();

            Doubles.PrintDoubles();

            #region concatenaciones de strings

            byte años = 18;
            string meazure = " edad";

            //concatenación con el simbolo mas
            Console.WriteLine("tienes " + años + " de" + meazure);

            //concatenación con interpolación
            Console.WriteLine($"Tienes una edad de {años} años");

            #endregion

            #region declaración de variables

            //declaración con tipo de datos--------------------------------------------


            int edad = 30;
            byte fingers; //al declarar con el tipo de dato se puede inicializar después
            fingers = 5; //inicializando la variable
            Console.WriteLine($"edad: {edad}, finguers {fingers}");

            //declaración con inferencia de datos---------------------------------------


            var name = "Andru"; //las variables con var no se pueden inicializar vacías
                                //y quedan fuertemente tipadas, asignar un tipo de datro distinto
            Console.WriteLine(name);

            #endregion
        }
    }
}

