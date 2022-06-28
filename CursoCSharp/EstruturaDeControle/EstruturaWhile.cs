using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturaDeControle {
    class EstruturaWhile {
        public static void Executar() {
            int palpite = 0;
            int tentativasRestantes = 5;
            bool nmrEncontrado = false;
            int tentativas = 0;
            Random random = new Random();
            int nmr = random.Next(1, 16);

            while(tentativasRestantes > 0 && !nmrEncontrado) {
                Console.WriteLine("Digite o seu palpite: ");
                string entrada = Console.ReadLine();
                int.TryParse(entrada, out palpite);

                tentativas++;
                tentativasRestantes--;

                if (palpite == nmr) {
                    nmrEncontrado = true;
                    Console.WriteLine($"Acertou em {tentativas} tentivas!");
                } else if (palpite > nmr) {
                    Console.WriteLine("Menor... Tente novamente.");
                } else {
                    Console.WriteLine("Maior... Tente novamente.");
                }
            }
        }
    }
}
