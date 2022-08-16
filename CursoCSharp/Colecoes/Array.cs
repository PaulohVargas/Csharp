using System;

namespace CursoCSharp.Colecoes {
    class Array {
        public static void Executar() {
            string[] nomes = new string[5];
            nomes[0] = "Paulo";
            nomes[1] = "Julliana";
            nomes[2] = "Bryan";
            nomes[3] = "Betina";
            nomes[4] = "Max";

            foreach (var nome in nomes) {
                Console.WriteLine(nome);
            }

            double[] notas = { 8.5, 9.3, 8.7, 10 };
            double soma = 0;

            foreach (var nota in notas) {
                soma += nota;
            }
            Console.WriteLine($"A média foi de {soma/notas.Length}");

            char[] letras = { 'A', 'r', 'r', 'a', 'y' };
            string palavra = new string(letras);
            Console.WriteLine($"Palavra: {palavra}");
        }
    }
}
