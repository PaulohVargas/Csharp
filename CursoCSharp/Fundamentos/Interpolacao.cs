using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    class Interpolacao {
        public static void Executar() {
            string nome = "Notebook Gamer";
            var marca = "Dell";
            double preco = 5299.99;

            Console.WriteLine("O " + nome + " da marca "
                + marca + " custa R$" + preco + ".");

            Console.WriteLine("O {0} da marca {1} custa R${2}."
                ,nome, marca, preco);

            Console.WriteLine($"O {nome} da {marca} é bom!!!");
        }
    }
}
