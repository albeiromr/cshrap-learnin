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

            #region scope de variables

            //el scope de la variables solo es dentro de las llaves en las que es declarada
            //un scope puede acceder a las variables declaradas en su scope padre
            //un scope hijo no puede declarar una variable ya declarada en su scope padre

            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            //i = 20; // fuera de scope

            #endregion
        }
    }
}
