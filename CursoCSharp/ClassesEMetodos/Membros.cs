using System;

namespace CursoCSharp.ClassesEMetodos {
    class Membros {
        public static void Executar() {
            Pessoa name = new Pessoa();
            name.Nome = "Paulo";
            name.Idade = 20;

            Console.WriteLine(name.Apresentacao());
        }
    }
}
