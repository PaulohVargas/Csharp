using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    class OperadoresRelacionais {
        public static void Executar() {
            double notaCorte = 7.0;

            Console.Write("Digite a nota: ");
            double.TryParse(Console.ReadLine(), out double nota);

            if(nota > 10 || nota < 0) {
                Console.WriteLine("Nota inválida!!");
            }
            else if(nota >= notaCorte) {
                Console.WriteLine("Aprovado!!!");
            } else {
                Console.WriteLine("Reprovado, sinto muito.");
            }
        }
    }
}
