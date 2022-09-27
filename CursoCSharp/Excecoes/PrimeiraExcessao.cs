using System;

namespace CursoCSharp.Excecoes {
    public class Conta {
        double Saldo;

        public Conta(double saldo) {
            Saldo = saldo;
        }

        public void Sacar(double vSaque) {
            if (vSaque > Saldo) {
                throw new ArgumentException("Saldo Insuficiente.");
            }
            Saldo -= vSaque;
        }
    }
    class PrimeiraExcessao {
        public static void Executar() {
            var conta = new Conta(531.25);

            try {
                conta.Sacar(500.0);
                Console.WriteLine("Retirada efetuada com sucesso!");
            } catch (Exception ex) {
                Console.WriteLine(ex.GetType().Name);
                Console.WriteLine(ex.Message);
            } finally {
                Console.WriteLine("Obrigado.");
            }
        }
    }
}
