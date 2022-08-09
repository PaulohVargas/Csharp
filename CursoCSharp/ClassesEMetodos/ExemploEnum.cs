using System;

namespace CursoCSharp.ClassesEMetodos {

    public enum Genero { Acao, Aventura, Comedia, Suspense, Ficcao };

    public class Filme {
        public string Titulo;
        public Genero GeneroFilme;
    }

    class ExemploEnum {
        public static void Executar() {
            int id = (int)Genero.Aventura;
            Console.WriteLine(id);

            var f = new Filme();
            f.Titulo = "Doutor estranho";
            f.GeneroFilme = Genero.Ficcao;
            Console.WriteLine($"{f.Titulo} é do gênero: {f.GeneroFilme}");
        }
    }
}
