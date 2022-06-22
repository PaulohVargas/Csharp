using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    class OperadoresAritmeticos {
        public static void Executar() {
            Console.WriteLine("...:::Vamos calcular seu IMC:::...");
            Console.WriteLine("Digite seu peso: ");
            float.TryParse(Console.ReadLine(), out float peso);
            Console.WriteLine("Digite sua altura: ");
            float.TryParse(Console.ReadLine(), out float altura);

            Console.WriteLine($"Seu IMC é: {peso / Math.Pow(altura,2)}");

            int par = 2;
            int inpar = 3;

            Console.WriteLine($"{par}/2 tem resto: {par % 2}");
            Console.WriteLine($"{inpar}/2 tem resto: {inpar % 2}");
        }
    }
}
