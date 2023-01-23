﻿using System;

namespace aplicacion1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region enteros
            //reference  https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/integral-numeric-types


            //sbyte: entre -127 y 128
            sbyte number125 = -105;
            Console.WriteLine(number125);

            //byte: de 0 a 255
            byte number230 = 230;
            Console.WriteLine(number230);

            //short: entre -32,768 y 32,767
            short number32000 = 32000;
            Console.WriteLine(number32000);

            //ushort: entre 0 y 65,535;
            ushort number62000 = 62000;
            Console.WriteLine(number62000);

            //int: entre -2,147,483,648 y 2,147,483,647
            int number15692613 = 15692613;
            Console.WriteLine(number15692613);

            //uint: entre 0 y 4,294,967,295
            uint number4000000 = 4000000;
            Console.WriteLine(number4000000);

            //long: entre -9,223,372,036,854,775,808 y 9,223,372,036,854,775,807
            long number2323232323232323232 = 2323232323232323232;
            Console.WriteLine(number2323232323232323232);

            //ulong: entre 0 y 18,446,744,073,709,551,615
            ulong number569569569569569 = 569569569569569;
            Console.WriteLine(number569569569569569);

            #endregion

            #region flotantes

            //tipos de datos de punto flotante
            //reference  https://www.youtube.com/watch?v=7OcIQEO9psc&ab_channel=ElCaminoDev
            //reference 2 https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/floating-point-numeric-types#code-try-1

            //decimal: muchísima mas precisión, 28-29 digits, menor rendimiento, numero con base 10, Literal m
            decimal decimaluno = 2.1m;
            Console.WriteLine(decimaluno);

            //double: presición intermedia pero mas rendimiento, ~15-17 digits, numero con base 2, literal D
            double doubleuno = 3.569536D;
            Console.WriteLine(doubleuno);

            //float: menor presición que el double, ~6-9 digits, mas rendimiento, literal F
            float floatuno  = 5.8890F;
            Console.WriteLine(floatuno);

            #endregion
        }
    }
}

