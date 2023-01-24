using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aplicacion1.scape_sequences
{
    internal class ScapeSequences
    {
        public static void PrintScapeSequences()
        {
            #region scape sequences

            //backslash keyboard shortcut alt + 92;

            //single quote
            string sigleQuote = $"single quote at the end \'";
            Console.WriteLine(sigleQuote);

            //double quote 
            string doubleQoute = $"double quote at the end \"";
            Console.WriteLine(doubleQoute);

            //backslash
            string backslash = $"backslash at the end \\";
            Console.WriteLine(backslash);

            //null, no hace nada
            string null1 = $"null at the end \0";
            Console.WriteLine(null1);

            //alert, emite el sonido de alerta de windows 
            string alert = $"trigger alert OS sound \a";
            Console.WriteLine(alert);

            //backspace
            string backSpace = $"back space at the final letter \b:)";
            Console.WriteLine(backSpace);

            //new line, agrega un espacio vertical
            string newLine = $"new line \n at the end";
            Console.WriteLine(newLine);
            #endregion

        }
    }
}
