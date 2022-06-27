using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturaDeControle {
    class EstruturaIf {
        public static void Executar() {
            string entrada;
            Console.WriteLine("Digite a nota do aluno: ");
            entrada = Console.ReadLine();
            double.TryParse(entrada, out double nota);

            if (nota >= 70) {
                Console.WriteLine("O aluno está aprovado!!!");
            }
            else if(nota >= 60 && nota < 70) {
                Console.WriteLine("O aluno está de recuperação.");
            } else {
                Console.WriteLine("O aluno está reprovado.");
            }

        }
    }
}
