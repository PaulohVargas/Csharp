using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.OO {
    sealed class Fortuna {
        public double ValorF() {
            return 1_333_945.67;
        }
    }
    //public class NHerda : Fortuna {}

    public class Avo {
        public virtual bool HonraNome() {
            return true;
        }
    }
    public class Pai : Avo {
        public override sealed bool HonraNome() {
            return true;
        }
    }
    //public class FilhoRebelde : Pai {
    //    public override bool HonraNome() {
    //        return false;
    //    }
    //}

    class Seaaled {
        public static void Executar() {
            Fortuna fortuna = new Fortuna();
            Console.WriteLine(fortuna.ValorF());

            Pai pai = new Pai();
            Console.WriteLine(pai.HonraNome());
        }
    }
}
