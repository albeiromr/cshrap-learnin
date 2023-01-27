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
            int[] ints2 = new int[3] { 1, 2, 3}; 

            //inicializando el arreglo sin el constructor new
            //el compilador infiere que la longitud del arreglo
            int[] ints3 = { 1, 2, 3, 4, 5, 6 };

            #endregion

            #region arreglos multidimensionales

            //Arreglos multidimencionales----------------------------------------------------

            //sintaxis:   datatype varible_name new datatype[ numero de dimensiones , elementos por dimension]


            int[,] arr1;
            arr1 = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };

            int[,] arr2 = new int[2,2]{ { 1, 2 }, { 3, 4 } };

            int[,] arr3 = { { 4, 5 }, { 7, 8 } };//infiere dimensiones y cantidad de elementos

            int[,] arr4 = new int[,] { { 1, 2, 3 }, { 4, 5, 6 } }; //infiere dimensiones y cantidad de elementos

            #endregion
        }
    }
}
