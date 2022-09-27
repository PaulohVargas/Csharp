using System;

namespace CursoCSharp.Excecoes {
    public class NegativoException : Exception {
        public NegativoException() { }
        public NegativoException(string msg) : base(msg) { }
        public NegativoException(string msg, Exception inner) : base(msg, inner){ }
    }
    public class ImparException : Exception {
        public ImparException(string msg) : base(msg) { }
    }
    class ExcecaoPersonalizada {
        public static int PositivoPar() {
            Random random = new Random();
            int valor = random.Next(-10, 10);

            if(valor < 0) {
                throw new NegativoException("Número negativo.");
            }
            if(valor %2 == 1) {
                throw new ImparException("Número ímpar.");
            }
            return valor;
        }
        public static void Executar() {
            try {
                Console.WriteLine(PositivoPar());
            } catch (NegativoException ex) {
                Console.WriteLine(ex.Message);
            } catch (ImparException ex) {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
