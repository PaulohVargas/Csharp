using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.OO {

    public class Comida {
        public double Peso;

        public Comida(double peso) {
            Peso = peso;
        }
        public Comida() { }
    }

    public class Feijao : Comida{ 
        public Feijao(double peso) : base(peso){}
    }
    public class Arroz : Comida{
        public Arroz(double peso) : base(peso) { }
    }
    public class Carne : Comida{
        public Carne(double peso) : base(peso) { }
    }

    public class Pessoa {
        public double Peso;
        public void Comer(Comida comida) {
            Peso += comida.Peso;
        }
    }
    class Polimorfismo {
        public static void Executar() {
            Feijao ing1 = new Feijao(0.24);
            Arroz ing2 = new Arroz(0.45); ;
            Carne ing3 = new Carne(0.22);

            Pessoa pessoa = new Pessoa();
            pessoa.Peso = 73.2;
            pessoa.Comer(ing1);
            pessoa.Comer(ing2);
            pessoa.Comer(ing3);

            Console.WriteLine($"Peso atual: {pessoa.Peso}Kg");

        }
    }
}
