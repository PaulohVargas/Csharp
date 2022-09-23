using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.OO {
    public abstract class Celular {
        public abstract string Assistente();

        public string Toque() {
            return "Tililim Tililim Tililim";
        }
    }

    public class Sansung : Celular {
        public override string Assistente() {
            return "Olá! Meu nome é Bixby";
        }
    }
    public class Iphone : Celular {
        public override string Assistente() {
            return "Olá! Meu nome é Siri";
        }
    }

    class Abstract {
        public static void Executar() {
            var celulares = new List<Celular> {
                new Sansung(),
                new Iphone(),
            };

            foreach (var celular in celulares) {
                Console.WriteLine($"\n{celular.Toque()}");
                Console.WriteLine(celular.Assistente());
            }
        }
    }
}
