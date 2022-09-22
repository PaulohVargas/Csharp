using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamento {
    public class AmigoProximo {

        public readonly SubCelebridade amigo = new SubCelebridade();

        public new void MeusAcessos() {
            Console.WriteLine("\nAmigo Próximo...");

            Console.WriteLine(amigo.InfoPublica);
            Console.WriteLine(amigo.NumeroCel);
            Console.WriteLine(amigo.JeitoDeFalar);
        }
    }
}
