using System;
using System.IO;

namespace CursoCSharp.ExplorandoApi {
     class ExemploPath {
        public static void Executar() {
            var arquivo = @"~/exemplo_path_arquivo.txt".ParseHome();
            var pasta = @"~/exemplo_path_pasta".ParseHome();

            if (!File.Exists(arquivo)) {
                using (StreamWriter sw = File.CreateText(arquivo)) {
                    sw.WriteLine("Criando arquivo path");
                }
            }
            if (!Directory.Exists(pasta)) { 
                Directory.CreateDirectory(pasta);
            }

            Console.WriteLine(Path.GetFileName(arquivo));
            Console.WriteLine(Path.GetDirectoryName(arquivo));

            Console.WriteLine(Path.GetFullPath(pasta));
            Console.WriteLine(Path.GetPathRoot(pasta));
        }
    }
}
