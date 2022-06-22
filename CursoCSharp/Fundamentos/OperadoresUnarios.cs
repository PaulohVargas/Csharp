using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    class OperadoresUnarios {
        public static void Executar() {
            var numN = -5;
            var num = 3;
            var bolleano = true;

            Console.WriteLine(-numN);
            Console.WriteLine(!bolleano);

            num++; // ou --
            Console.WriteLine(num);
        }
    }
}
