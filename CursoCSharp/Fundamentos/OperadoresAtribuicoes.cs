using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    class OperadoresAtribuicoes {
        public static void Executar() {
            var num = 3;
            num = 7;
            num += 10; //num + 10
            num -= 3; //num -3
            num *= 5; // num * 5
            num /= 2; //num / 2

            Console.WriteLine(num);

            int a = 1;
            int b = a;

            //Referência:
            dynamic c = new System.Dynamic.ExpandoObject();
            c.nome = "João";

            dynamic d = c;
            d.nome = "Maria";

            Console.WriteLine(c.nome);
        }

    }
}
