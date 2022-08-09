using System;


namespace CursoCSharp.ClassesEMetodos {
    class ClasseVSStruct {
        public struct Sponto {
            public int X;
            public int Y;
        }
        public class Cponto {
            public int X;
            public int Y;
        }

        public static void Executar() {
            Sponto ponto1 = new Sponto {X = 2, Y = 3};
            Sponto copiaPonto1 = ponto1; // Atribuição por VALOR!!!
            ponto1.X = 3;
            Console.WriteLine($"Ponto: {ponto1.X} , {ponto1.Y}");
            Console.WriteLine($"Cópia: {copiaPonto1.X} , {copiaPonto1.Y}");

            Cponto ponto2 = new Cponto {X = 4, Y = 6};
            Cponto copiaPonto2 = ponto2; // Atribuição por REFERÊNCIA!!!
            ponto2.X = 6;
            Console.WriteLine($"Ponto: {ponto2.X} , {ponto2.Y}");
            Console.WriteLine($"Cópia: {copiaPonto2.X} , {copiaPonto2.Y}");

        }

    }
}
