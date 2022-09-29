using System;
using System.IO;

namespace CursoCSharp.ExplorandoApi {
    class Diretorios {
        public static void Executar() {
            var novoDir = @"~/PastaCSharp".ParseHome();
            var novoDirDestino = @"~/PastaCSharpDestino".ParseHome();
            var caminhoProj = @"C:\Users\Paulo Vargas\Desktop\Cursos\C#";

            if (Directory.Exists(novoDir)) {
                Directory.Delete(novoDir, true);
            }
            if (Directory.Exists(novoDirDestino)) {
                Directory.Delete(novoDirDestino, true);
            }

            Directory.CreateDirectory(novoDir);
            Console.WriteLine(Directory.GetCreationTime(novoDir));

            Console.WriteLine("== Pastas projeto =====");
            var pastas = Directory.GetDirectories(caminhoProj);
            foreach (var pasta in pastas) {
                Console.WriteLine(pasta);
            }
            Console.WriteLine("\n\n== Arquivos projeto =====");
            var arquivos = Directory.GetFiles(caminhoProj);
            foreach (var arquivo in arquivos) {
                Console.WriteLine(arquivo);
            }

            Console.WriteLine("\n\n== Raiz projeto =====");
            Console.WriteLine(Directory.GetDirectoryRoot(caminhoProj));

            Directory.Move(novoDir, novoDirDestino);
        }
    }
}
