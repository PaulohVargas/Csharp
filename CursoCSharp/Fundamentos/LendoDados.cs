using System;
using System.Globalization;

namespace CursoCSharp.Fundamentos {
    class LendoDados {
        public static void Executar() {
            Console.WriteLine("Qual é o seu nome?");
            string nome = Console.ReadLine();

            Console.WriteLine("Qual é sua idade? ");
            int idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual seu salário?");
            float salario = float.Parse(Console.ReadLine(),
                CultureInfo.InvariantCulture); //nesse caso utiliza ponto como separador

            Console.WriteLine($"{nome} tem {idade} anos e recebe" +
                $" um salário de R${salario}.");
        }
    }
}
