using System;
using System.Collections.Generic;
using System.Linq;

namespace CursoCSharp.Colecoes {

    class ExHashSet {
        public static void Executar() {
            var livro = new Produto("Game of Thrones", 54.90);

            var carrinho = new HashSet<Produto>();
            carrinho.Add(livro);

            var combo = new HashSet<Produto> {
                new Produto("Camisa", 40),
                new Produto("Caderno", 25.7),
                new Produto("Poster", 10)
            };

            carrinho.UnionWith(combo);
            //carrinho.RemoveAt(3);
            carrinho.Add(livro);

            Console.WriteLine($"Seu carrinho possui {carrinho.Count} itens, sendo eles: ");
            foreach (var item in carrinho) {
                Console.WriteLine($"{item.Nome}, no valor de R${item.Preco}");
            }

            double soma = 0;
            foreach (var a in carrinho) {
                soma += a.Preco;
            }
            Console.WriteLine($"Total: R${soma}");
        }
    }
}
