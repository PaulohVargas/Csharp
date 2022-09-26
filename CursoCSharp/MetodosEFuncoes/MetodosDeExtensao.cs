using System;

namespace CursoCSharp.MetodosEFuncoes {
    public static class ExtensoesInteiro {
        public static int Soma(this int a, int b) { 
            return a + b;
        }
        public static int Subtracao(this int a, int b) {
            return a - b;
        }
    }
    class MetodosDeExtensao {
        public static void Executar() {
            var numero = 5;
            Console.WriteLine(numero.Soma(3));
            Console.WriteLine(numero.Subtracao(3));
            Console.WriteLine(2.Soma(3));
        }
    }
}
