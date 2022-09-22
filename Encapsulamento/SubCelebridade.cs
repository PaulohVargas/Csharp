using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamento {
    public class SubCelebridade {
        //Todos
        public string InfoPublica = "Eu tenho instagram!";

        //Herança
        protected string CorOlhos = "Castanho";

        //Mesmo projeto (assembly)
        internal ulong NumeroCel = 5546999245393;

        //Herança ou mesmo projeto
        protected internal string JeitoDeFalar = "Uso muitas gírias";

        //Mesma classe ou herança do mesmo projeto
        private protected string SegredoFamilia = "Bla bla.";

        //Private (padrão)
        bool UsoPhothoshop = false;

        public void MeusAcessos() {
            Console.WriteLine("\nSub Celebridade...");

            Console.WriteLine(InfoPublica);
            Console.WriteLine(CorOlhos);
            Console.WriteLine(NumeroCel);
            Console.WriteLine(JeitoDeFalar);
            Console.WriteLine(SegredoFamilia);
            Console.WriteLine(UsoPhothoshop);
        }
    }
}
