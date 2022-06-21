using System;
using System.Globalization;

namespace CursoCSharp.Fundamentos {
    class FormatandoNumeros {
        public static void Executar() {
            double valor = 15.175;
            Console.WriteLine(valor.ToString("F1"));
            Console.WriteLine(valor.ToString("C")); //Moeda
            Console.WriteLine(valor.ToString("P")); //percentual

            CultureInfo cultura = new CultureInfo("en-US");
            Console.WriteLine(valor.ToString("C2", cultura));

            int inteiro = 256;
            Console.WriteLine(inteiro.ToString("D10"));
        }
    }
}
