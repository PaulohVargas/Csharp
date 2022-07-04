using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturaDeControle {
    class EstruturaFor {
        public static void Executar() {
            double soma = 0;
            string entrada;

            Console.WriteLine("A turma tem quantos alunos? ");
            entrada = Console.ReadLine();
            int.TryParse(entrada, out int tmnTurma);

            for (int i = 1; i <= tmnTurma; i++) {
                Console.Write($"Informe a nota do aluno {i}: ");
                entrada = Console.ReadLine();
                double.TryParse(entrada, out double nota);

                soma += nota;
            }
            double media = tmnTurma > 0 ? soma / tmnTurma : 0;
            Console.WriteLine($"A média da turma é: {media}");
        }
    }
}
