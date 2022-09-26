using System;

namespace CursoCSharp.MetodosEFuncoes {
    class DelegateComoParametro {
        public delegate int Operacao(int a, int b);

        public static int Soma(int a, int b) {
            return a + b;
        }

        public static string Calculadora(Operacao op, int a, int b) {
            var resultado = op(a, b);
            return "Resultado: " + resultado;
        }
        public static void Executar() {
            Operacao sub = (int x, int y) => x - y;
            Console.WriteLine(Calculadora(sub, 5,3));

            Console.WriteLine(Calculadora(Soma, 3,2));

        }
    }
}
