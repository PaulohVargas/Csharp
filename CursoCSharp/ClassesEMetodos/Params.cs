using System;

namespace CursoCSharp.ClassesEMetodos {
    class Params {
        public static void Recepcionar(params string[] pessoas) {
            foreach (var pessoa in pessoas) {
                Console.WriteLine($"Olá {pessoa}, seja muito bem vindo!");
            }
        }
        public static void Executar() {
            Recepcionar("Paulo", "Julliana", "Bryan");
        }
    }
}
