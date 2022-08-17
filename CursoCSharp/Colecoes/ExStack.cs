using System;
using System.Collections;

namespace CursoCSharp.Colecoes {
    class ExStack {
        public static void Executar() {
            var pilha = new Stack();

            pilha.Push(3);
            pilha.Push("Fast");
            pilha.Push(3.14f);

            foreach (var item in pilha) {
                Console.Write($"{item} ");
            }
            Console.WriteLine($"\nPop: {pilha.Pop()}");

            foreach (var item in pilha) {
                Console.Write($"\n{item} ");
            }
        }
    }
}
