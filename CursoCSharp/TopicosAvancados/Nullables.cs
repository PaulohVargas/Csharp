using System;

namespace CursoCSharp.TopicosAvancados {
    class Nullables {
        public static void Executar() {
            Nullable<int> num1 = null;
            int? num2 = null;

            if (num1.HasValue) {
                Console.WriteLine($"Valor do número: {num1}");
            } else {
                Console.WriteLine("O número não possui valor.");
            }

            int num3 = num1 ?? 0;
            Console.WriteLine($"Num3: {num3}");

            bool? bolleana = null;
            bool bool2 = bolleana.GetValueOrDefault();
            Console.WriteLine($"\n{bool2}");

            try {
                int x = num1.Value;
                int y = num2.Value;
                Console.WriteLine(x + y);
            } catch (Exception ex){
                Console.WriteLine(ex.Message);
            }
        }
    }
}
