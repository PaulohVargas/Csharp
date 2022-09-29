using System;
using System.Linq;

namespace CursoCSharp.TopicosAvancados {

    public class Aluno {
        public string Nome;
        public int Idade;
        public double Nota;
    }
    class LINQ1 {
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

            Console.WriteLine("== Aprovados =====");
            var aprovados = alunos.Where(a => a.Nota >= 7).OrderBy(a => a.Nome);
            foreach(var aluno in aprovados) {
                Console.WriteLine(aluno.Nome);
            }

            Console.WriteLine("\n== Chamada =====");
            var chamada = alunos.OrderBy(a => a.Nome).Select(a => a.Nome);
            foreach (var aluno in chamada) {
                Console.WriteLine(aluno);
            }

            Console.WriteLine("\n== Aprovados por idade =====");
            var aprovadosIdade =
                from aluno in alunos
                where aluno.Nota >= 7
                orderby -aluno.Idade
                select aluno.Nome;
            foreach (var aluno in aprovadosIdade) {
                Console.WriteLine(aluno);
            }
        }
    }
}
