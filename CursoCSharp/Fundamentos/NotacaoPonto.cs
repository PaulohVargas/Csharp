using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    class NotacaoPonto {
        public static void Executar() {
            var saudacao = "olá".Insert(3, " World!")
                .Replace("World!", "Mundo!").ToUpper();

            Console.WriteLine(saudacao);

            string valor = null;
            Console.WriteLine(valor?.Length);
        }
    }
}
