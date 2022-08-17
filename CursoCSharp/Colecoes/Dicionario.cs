using System;
using System.Collections.Generic;

namespace CursoCSharp.Colecoes {
    class Dicionario {
        public static void Executar() {
            var filmes = new Dictionary<int, string>();

            filmes.Add(2000, "Gladiador");
            filmes.Add(2002, "Homem-aranha");
            filmes.Add(2006, "O grande truque");

            if (filmes.ContainsKey(2002)) {
                Console.WriteLine("2002: " + filmes[2002]);
                Console.WriteLine("2004: " + filmes.GetValueOrDefault(2004));
            }

            Console.WriteLine(filmes.ContainsValue("Amnésia"));
            Console.WriteLine("Removeu: " + filmes.Remove(2000));

            filmes.TryGetValue(2006, out string filme2006);
            Console.WriteLine("Filme 2006: " + filme2006);

            foreach (var filme in filmes.Keys) {
                Console.Write($"{filme}; ");
            }

            Console.WriteLine("\n");
            foreach (var filme in filmes.Values) {
                Console.Write($"{filme}; ");
            }

            Console.WriteLine("\n");
            foreach (KeyValuePair<int, string> filme in filmes) {
                Console.WriteLine($"{filme.Value} é de {filme.Key}");
            }

            foreach (var filme in filmes) {
                Console.WriteLine($"{filme.Value} é de {filme.Key}");
            }
        }
    }
}
