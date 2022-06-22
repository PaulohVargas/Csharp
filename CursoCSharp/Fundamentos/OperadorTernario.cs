using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    class OperadorTernario {
        public static void Executar() {
            Console.WriteLine("Qual a nota do aluno? ");
            float nota = float.Parse(Console.ReadLine());

            string resultado = nota >= 7.0 ? "Aprovado" : "Reprovado";
            Console.WriteLine(resultado);
        }
    }
}
