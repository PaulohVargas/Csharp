using System;

namespace CursoCSharp.ClassesEMetodos {

    public class Cliente {
        public string Nome;
        readonly DateTime Nascimento;

        public Cliente(string nome, DateTime nascimento) { 
            Nome = nome;
            Nascimento = nascimento;
        }
        public string GetData() {
            return String.Format("{0}/{1}/{2}", Nascimento.Day, Nascimento.Month, Nascimento.Year);

        }
    }

    class Readonly {
        public static void Executar() {
            var cliente = new Cliente("Paulo Vargas", new DateTime(2002, 7, 17));
            Console.WriteLine(cliente.Nome);
            Console.WriteLine(cliente.GetData());
        }
    }
}
