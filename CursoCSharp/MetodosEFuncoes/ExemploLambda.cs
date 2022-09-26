using System;

namespace CursoCSharp.MetodosEFuncoes {
    class ExemploLambda {
        public static void Executar() {
            Action<string> algonoConsole = (s) => {
                Console.WriteLine("Lambda em C#" + s);
            };

            algonoConsole("!!!");

            Func<int> jogarDado = () => {
                Random random = new Random();
                return random.Next(1, 7);
            };

            Console.WriteLine(jogarDado());

            Func<int, string> convertHexa = numero => numero.ToString("X");
            Console.WriteLine(convertHexa(1234));

            Func<int, int, int, string> formataData = (dia, mes, ano) => String.Format("{0:D2}/{1:D2}/{2:D4}", dia, mes, ano);
            Console.WriteLine(formataData(26, 9, 2022));
        }
    }
}
