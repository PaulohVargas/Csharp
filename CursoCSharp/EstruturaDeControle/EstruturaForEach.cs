using System;

namespace CursoCSharp.EstruturaDeControle {
    internal class EstruturaForEach {
        public static void Executar() {
            var alunos = new string[] { "Paulo", "Julliana", "Bryan" };

            foreach (var nome in alunos) {
                Console.WriteLine(nome);
            }
        }
    }
}
