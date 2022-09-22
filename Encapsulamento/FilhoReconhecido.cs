using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamento {
    public class FilhoReconhecido : SubCelebridade{
        public new void MeusAcessos() {
            Console.WriteLine("\nFilho Reconhecido...");

            Console.WriteLine(InfoPublica);
            Console.WriteLine(CorOlhos);
            Console.WriteLine(NumeroCel);
            Console.WriteLine(JeitoDeFalar);
            Console.WriteLine(SegredoFamilia);
           
        }
    }
}
