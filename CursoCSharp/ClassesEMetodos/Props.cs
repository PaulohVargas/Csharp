using System;

namespace CursoCSharp.ClassesEMetodos {

    public class OpcionalCarro {
        double desconto = 0.1;
        string nome;

        public string Nome {
            get { return "Opcional: " + nome; }
            set { nome = value; }
        }
  
        public double Preco { get; set; } //Propriedade autoimplementada
                                         
        public double PrecoComDesconto { //Somente Leitura
            get => Preco - (desconto * Preco); //Lambda
        }

        public OpcionalCarro() { }

        public OpcionalCarro(string nome, double preco) { 
            this.nome = nome;
            Preco = preco;
        }
    }
    class Props {
        public static void Executar() {
            var op1 = new OpcionalCarro("Ar condicionado ", 3500.50);
            var op2 = new OpcionalCarro();
            op2.Nome = "Vidros elétricos";
            op2.Preco = 1200;

            Console.WriteLine(op1.Nome);
            Console.WriteLine($"Preço normal: R${op1.Preco}");
            Console.WriteLine($"Preço com desconto: R${op1.PrecoComDesconto}");

            Console.WriteLine(op2.Nome);
            Console.WriteLine($"Preço normal: R${op2.Preco}");
            Console.WriteLine($"Preço com desconto: R${op2.PrecoComDesconto}");
        }
    }
}
