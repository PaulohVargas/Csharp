using Encapsulamento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.OO {
    public class FilhoNaoReconhecido : SubCelebridade {
        public new void MeusAcessos() {
            Console.WriteLine("\nFilho não reconhecido...");

            Console.WriteLine(InfoPublica);
            Console.WriteLine(CorOlhos);
            Console.WriteLine(JeitoDeFalar);
        }
    }

    public class AmigoDistante {
        public readonly SubCelebridade amigo = new SubCelebridade();

        public void MeusAcessos() {
            Console.WriteLine("\nAmigo distante");

            Console.WriteLine(amigo.InfoPublica);
        }
    }
    class Encapsulamento {
        public static void Executar() {
            new SubCelebridade().MeusAcessos();
            new FilhoReconhecido().MeusAcessos();
            new FilhoNaoReconhecido().MeusAcessos();
            new AmigoProximo().MeusAcessos();
            new AmigoDistante().MeusAcessos();

        }
    }
}
