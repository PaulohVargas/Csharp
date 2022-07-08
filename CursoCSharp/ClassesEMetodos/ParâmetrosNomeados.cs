using System;

namespace CursoCSharp.ClassesEMetodos {
    class ParâmetrosNomeados {
        public static void Formatar(int dia, int mes, int ano) {
            Console.WriteLine($"{dia:D2}/{mes:D2}/{ano:D2}");
        }
        public static void Executar() {
            Formatar(mes: 8, dia: 1, ano: 2021);
        }
    }
}