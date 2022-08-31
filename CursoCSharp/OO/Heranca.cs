using System;

namespace CursoCSharp.OO {
    public class Carro {
        protected readonly int VelocidadeMaxima;
        int VelocidadeAtual;

        public Carro(int velocidadeMaxima) {
            VelocidadeMaxima = velocidadeMaxima;
        }

        protected int AlterarVelocidade(int delta) {
            int novaVelocidade = VelocidadeAtual + delta;

            if (novaVelocidade < 0) {
                VelocidadeAtual = 0;
            } else if (novaVelocidade > VelocidadeMaxima) {
                VelocidadeAtual = VelocidadeMaxima;
            } else {
                VelocidadeAtual = novaVelocidade;
            }
            return VelocidadeAtual;
        }

        public virtual int Acelerar() {
            return AlterarVelocidade(5);
        }
        public int Frear() {
            return AlterarVelocidade(-5);
        }
    }

    public class Uno : Carro {
        public Uno() : base(160) { }
    }

    public class Ferrari : Carro {
        public Ferrari() : base(160) { }

        public override int Acelerar() {
            return AlterarVelocidade(15);
        }

        //Oculta o método da classe pai!!!
        public new int Frear() {
            return AlterarVelocidade(-15);
        }
    }

    class Heranca {

        public static void Executar() {
            Uno carro1 = new Uno();

            Console.WriteLine("Uno...");
            Console.Write($" {carro1.Acelerar()}");
            Console.Write($" {carro1.Acelerar()}");
            Console.Write($" {carro1.Acelerar()}");
            Console.Write($" {carro1.Frear()} ");

            Ferrari carro2 = new Ferrari();
            Console.WriteLine("\nFerrari...");
            Console.Write($" {carro2.Acelerar()}");
            Console.Write($" {carro2.Acelerar()}");
            Console.Write($" {carro2.Acelerar()}");
            Console.Write($" {carro2.Frear()} ");

            Carro carro3 = new Ferrari();
            Console.WriteLine("\nFerrari com tipo carro...");
            Console.Write($" {carro3.Acelerar()}");
            Console.Write($" {carro3.Acelerar()}");
            Console.Write($" {carro3.Acelerar()}");
            Console.Write($" {carro3.Frear()} ");

            carro3 = new Uno();
            Console.WriteLine("\nUno com tipo carro...");
            Console.Write($" {carro3.Acelerar()}");
            Console.Write($" {carro3.Acelerar()}");
            Console.Write($" {carro3.Acelerar()}");
            Console.Write($" {carro3.Frear()} ");
        }
    }
}
