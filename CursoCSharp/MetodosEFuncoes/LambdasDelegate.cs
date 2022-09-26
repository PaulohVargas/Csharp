using System;

namespace CursoCSharp.MetodosEFuncoes {

    delegate double Operacao(double x, double y);
    class LambdasDelegate {
        delegate double Soma(double x, double y);
        delegate void ImprimirSoma(double x, double y);

        static double MinhaSoma(double x, double y) {
            return x + y;
        }

        static void MeuImprimeSoma(double x, double y) {
            Console.WriteLine(x + y);
        }
        public static void Executar() {
            Operacao sum = (x, y) => x + y;
            Operacao sub = (x, y) => x - y;
            Operacao multi = (x, y) => x * y;

            Console.WriteLine(sum(5 , 2));
            Console.WriteLine(sub(5 , 2));
            Console.WriteLine(multi(5 , 2));

            Console.WriteLine("---------");
            Soma op1 = MinhaSoma;
            Console.WriteLine(op1(2 , 3.5));

            ImprimirSoma op2 = MeuImprimeSoma;
            op2(14 , 5.2);

            Func<double, double, double> op3 = MinhaSoma;
            Console.WriteLine(op3(2,5));

            Action<double, double> op4 = MeuImprimeSoma;
            op4(7, 3);
        }
    }
}
