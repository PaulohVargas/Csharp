using System;

namespace CursoCSharp.ClassesEMetodos {

    public class Calculadora {
        public int Somar(int a, int b) {
            return a + b;
        }
        public int Subtrair(int a, int b) {
            return a - b;
        }
        public int Multiplicar(int a, int b) {
            return a * b;
        }
        public int Divisao(int a, int b) {
            return a / b;
        }
    }

    class CalcCadeia {
        int memoria;
        public CalcCadeia Somar(int a) {
            memoria += a;
            return this;
        }
        public CalcCadeia Subtrair(int a) {
            memoria -= a;
            return this;
        }
        public CalcCadeia Imprimir() {
            Console.WriteLine(memoria);
            return this; // retorna o própiro objeto 
        }
        public CalcCadeia Limpar() {
            memoria = 0;
            return this;
        }
    }

    class MetodosComReturn {
        public static void Executar() {
            Console.WriteLine("Informe o primeiro número: ");
            int.TryParse(Console.ReadLine(), out int v1);
            Console.WriteLine("Informe o segundo número: ");
            int.TryParse(Console.ReadLine(), out int v2);

            var op = new Calculadora();

            Console.WriteLine("Informe a operação ( + , - , * , / )");
            string entrada = Console.ReadLine();

            switch (entrada) {
                case "+":
                    Console.WriteLine($"Soma: {op.Somar(v1, v2)}");
                    break;
                case "-":
                    Console.WriteLine($"Subtração: {op.Subtrair(v1, v2)}");
                    break;
                case "*":
                    Console.WriteLine($"Multiplicação: {op.Multiplicar(v1, v2)}");
                    break;
                case "/":
                    Console.WriteLine($"Divisão: {op.Divisao(v1, v2)}");
                    break;
                default:
                    Console.WriteLine("Operação inválida!");
                    break;
            }

            var calc = new CalcCadeia();

            Console.WriteLine("Calculadora Cadeia:");
            calc.Somar(v1).Subtrair(v2).Imprimir().Limpar().Imprimir();
        }
    }
}
