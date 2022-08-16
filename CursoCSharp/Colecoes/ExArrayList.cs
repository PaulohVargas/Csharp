using System;
using System.Collections;

namespace CursoCSharp.Colecoes {
    class ExArrayList {
        public static void Executar() {
            var al = new ArrayList {
                "Paulo", 3, true, 3.14
            };

            foreach(var item in al) {
                Console.WriteLine($"Item: {item} | Tipo: {item.GetType()}");

            }
        }
    }
}
