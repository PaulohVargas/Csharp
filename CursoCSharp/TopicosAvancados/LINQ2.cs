using System;
using System.Linq;

namespace CursoCSharp.TopicosAvancados {
    class LINQ2 {
        public static void Executar() {
            var alunos = new List<Aluno> {
                new Aluno () {Nome = "Paulo", Idade = 20, Nota = 9.2},
                new Aluno () {Nome = "Julliana", Idade = 18, Nota = 7.4},
                new Aluno () {Nome = "Bryan", Idade = 18, Nota = 8.9},
                new Aluno () {Nome = "Paulo", Idade = 21, Nota = 8.3},
                new Aluno () {Nome = "Julia", Idade = 22, Nota = 6.0},
                new Aluno () {Nome = "Jorge", Idade = 22, Nota = 8.0},
                new Aluno () {Nome = "Lucas", Idade = 20, Nota = 6.4}
            };

            var jorge = alunos.Single(aluno => aluno.Nome.Equals("Jorge"));
            Console.WriteLine($"{jorge.Nome} tirou {jorge.Nota}");

            var fulano = alunos.SingleOrDefault(aluno => aluno.Nome.Equals("Fulano"));
            if (fulano == null) {
                Console.WriteLine("Aluno inexistente!");
            }

            var paulo = alunos.First(aluno => aluno.Nome.Equals("Paulo"));
            Console.WriteLine($"\n{paulo.Nome} tirou {paulo.Nota}");

            var sicrano = alunos.FirstOrDefault(aluno => aluno.Nome.Equals("Sicrano"));
            if (sicrano == null) {
                Console.WriteLine("Aluno inexistente!");
            }

            var outroPaulo = alunos.LastOrDefault(aluno => aluno.Nome.Equals("Paulo"));
            if (outroPaulo == null) {
                Console.WriteLine("Aluno inexistente!");
            } else {
                Console.WriteLine($"{outroPaulo.Nome} tirou {outroPaulo.Nota}");
            }

            var maiorNota = alunos.Max(aluno => aluno.Nota);
            Console.WriteLine($"\nMaior nota: {maiorNota}");
        }
    }
}
