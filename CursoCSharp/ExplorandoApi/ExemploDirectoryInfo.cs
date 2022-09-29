using System;
using System.IO;

namespace CursoCSharp.ExplorandoApi {
    class ExemploDirectoryInfo {
        public static void Executar() {
            var dirProj = @"C:\Users\Paulo Vargas\Desktop\Cursos\C#";

            var dirInfo = new DirectoryInfo(dirProj);

            if (!dirInfo.Exists) { 
                dirInfo.Create();
            }

            Console.WriteLine("== Arquivos =====");
            var arquivos = dirInfo.GetFiles();
            foreach (var arquivo in arquivos) {
                Console.WriteLine(arquivo);
            }

            Console.WriteLine("\n\n== Diretórios/Pastas =====");
            var pastas = dirInfo.GetDirectories();
            foreach (var pasta in pastas) {
                Console.WriteLine(pasta);
            }

            Console.WriteLine("\n" + dirInfo.FullName);
            Console.WriteLine(dirInfo.CreationTime);
        }
    }
}
