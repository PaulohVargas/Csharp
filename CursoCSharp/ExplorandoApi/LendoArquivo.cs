using System;
using System.IO;

namespace CursoCSharp.ExplorandoApi {
    class LendoArquivo {
        public static void Executar() {
            var path = @"~/lendo_arquivos.txt".ParseHome();

            if (!File.Exists(path)) {
                using (StreamWriter sw = File.AppendText(path)) {
                    sw.WriteLine("Produto;Preço;Quantidade");
                    sw.WriteLine("Caneta;2.79;215");
                    sw.WriteLine("Borracha;5.0;57");
                }
            }
            try {
                using (StreamReader sr = new StreamReader(path)) {
                    var texto = sr.ReadToEnd();
                    Console.WriteLine(texto);
                }
            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
