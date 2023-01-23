using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aplicacion1.variables
{
    internal class Variables
    {
        public static void PrintVariables()
        {
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
