using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    class OperadoresLogicos {
        public static void Executar() {
            var et1 = true;
            var et2 = false;

            bool cTV50 = et1 && et2;
            Console.WriteLine($"Comrprou TV50? = {cTV50}");

            var cSor = et1 || et2;
            Console.WriteLine($"Comprou sorvete? = {cSor}");

            var cTV32 = et1 ^ et2;
            Console.WriteLine($"Comprou TV32? = {cTV32}");

            Console.WriteLine($"Está saldável? {!cSor}");
        }
    }
}
