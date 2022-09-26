using System;

namespace CursoCSharp.MetodosEFuncoes {
    class DelegateFunAnonima {
        delegate string StringOp(string s);
        public static void Executar() {
            StringOp inverter = delegate (string s) {
                char[] frase = s.ToCharArray();
                Array.Reverse(frase);
                return new string(frase);
            };

            Console.WriteLine(inverter("Subi no onibus"));
        }
    }
}
