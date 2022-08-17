using System;
using System.Collections.Generic;
using System.Linq;

namespace CursoCSharp.Colecoes {

    public class Produto {
        public string Nome;
        public double Preco;

        public Produto(string nome, double preco) {
            Nome = nome;
            Preco = preco;
        }

        public override bool Equals(object? obj) {
            return obj is Produto produto &&
                   Nome == produto.Nome &&
                   Preco == produto.Preco;
        }

        public override int GetHashCode() {
            return HashCode.Combine(Nome, Preco);
        }
    }
    
    class List {
        public static void Executar() {
            var livro = new Produto("Game of Thrones", 54.90);

            var carrinho = new List<Produto>();
            carrinho.Add(livro);

            var combo = new List<Produto> {
                new Produto("Camisa", 40),
                new Produto("Caderno", 25.7),
                new Produto("Poster", 10)
            };

            carrinho.AddRange(combo);
            carrinho.RemoveAt(3);

            Console.WriteLine($"Seu carrinho possui {carrinho.Count} itens, sendo eles: ");
            foreach (var item in carrinho) {
                Console.WriteLine($"{item.Nome}, no valor de R${item.Preco}");
            }

            double soma = 0;
            foreach(var a in carrinho) {
                soma += a.Preco;
            }
            Console.WriteLine($"Total: R${soma}");
        }
    }
}
