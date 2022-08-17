using System;
using System.Collections;
using System.Collections.Generic;

namespace CursoCSharp.Colecoes {
    class Igualdade {
        public static void Executar() {
            var p1 = new Produto("P", 2);
            var p2 = new Produto("P", 2);
            var p3 = p2;

            Console.WriteLine(p1 ==  p2);
            Console.WriteLine(p3 == p2);

            Console.WriteLine(p1.Equals(p2));//Resto da implemenatção no arquivo ExHashSet
        }
    }
}
