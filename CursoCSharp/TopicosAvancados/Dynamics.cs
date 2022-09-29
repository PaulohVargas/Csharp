using System;

namespace CursoCSharp.TopicosAvancados {
    class Dynamics {
        public static void Executar() {
            dynamic meuobjeto = "Teste";
            meuobjeto = 3;
            meuobjeto++;
            Console.WriteLine(meuobjeto);

            dynamic aluno = new System.Dynamic.ExpandoObject();
            aluno.nome = "Paulo";
            aluno.nota = 9.5;
            Console.WriteLine($"\n{aluno.nome} tirou {aluno.nota}");
        }
    }
}
