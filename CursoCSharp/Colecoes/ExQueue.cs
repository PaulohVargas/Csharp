using System;
using System.Collections;
using System.Collections.Generic;

namespace CursoCSharp.Colecoes {
    internal class ExQueue {
        public static void Executar() {
            var fila = new Queue<string>();

            fila.Enqueue("Paulo");
            fila.Enqueue("Julliana");
            fila.Enqueue("Bryan");

            Console.WriteLine($"Primeiro da lista: {fila.Peek()}");

            Console.WriteLine($"Primeiro a ser retirado: {fila.Dequeue()}");
            foreach (var elemento in fila) {
                Console.WriteLine(elemento);
            }

            var mistura = new Queue();

            mistura.Enqueue(true);
            mistura.Enqueue(3.14);
            mistura.Enqueue("Nomes");


            Console.WriteLine("...:::Queue sem amarração:::...");
            foreach (var elemento in mistura) {
                Console.WriteLine(elemento);
            }
        }
    }
}
