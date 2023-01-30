using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace aplicacion1.arrays
{
    internal class Arrays
    {
        public static void PrintArrays()
        {
            #region arreglos de una sola dimension

            //!!! importante, una vez el arrglo es declarado su longitud no puede alterarse
            //es decir no se pueden agregar mas objetos a el

            //inicializando un array, la longitud es calculada por el compilador
            int[] ints = new int[] { 1, 2, 3, 4, 5, 6, 7, };

            //inicializando el arreglo declarando su longitud
            int[] ints2 = new int[3] { 1, 2, 3 };

            //inicializando el arreglo sin el constructor new
            //el compilador infiere que la longitud del arreglo
            int[] ints3 = { 1, 2, 3, 4, 5, 6 };

            #endregion

            #region arreglos multidimensionales

            //Arreglos multidimencionales----------------------------------------------------

            //sintaxis:   datatype varible_name new datatype[ numero de dimensiones , elementos por dimension]


            int[,] arr1;
            arr1 = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };

            int[,] arr2 = new int[2, 2] { { 1, 2 }, { 3, 4 } };

            int[,] arr3 = { { 4, 5 }, { 7, 8 } };//infiere dimensiones y cantidad de elementos

            int[,] arr4 = new int[,] { { 1, 2, 3 }, { 4, 5, 6 } }; //infiere dimensiones y cantidad de elementos

            //arreglos de mas de dos dimensiones son declarados de forma similar
            //ejemplo: 4 dimension, cada una con 3 dimensiones en su interior
            // cada una de estas 3 dimensiones con 2 enteros en su interior

            int[,,] arr7 = new int[4, 3, 2]
            {
             { { 11, 12}, { 13, 14}, {15, 16 } },
             { { 21, 22}, { 23, 24}, {25, 26 } },
             { { 31, 32}, { 33, 34}, {35, 36 } },
             { { 41, 42}, { 43, 44}, {45, 46 } }
            };

            #endregion

            #region jagged arrays

            //los jagged arrays son arreglos de arreglos, y se declaran de varias formas 
            //se puede ver en los siguientes ejemplos

            //arreglo de dos arreglos
            int[][] jaggedArr3 = new int[2][]
            {
                new int[] {5,6},
                new int[] {7,8, 9, 10}
            };

            //sin usar el constructor new
            int[][] jaggedArr5 =
            {
             new int[] { 1, 2, 3 },
             new int[] { 1, 1, 2, 3, 5, 8 }
            };

            #endregion
        }
    }
}
