using System;
using System.IO;

namespace CursoCSharp.ExplorandoApi {
    public static class ExtensaoString {
        public static string ParseHome(this string path) {
            string home = (Environment.OSVersion.Platform == PlatformID.Unix || Environment.OSVersion.Platform == PlatformID.MacOSX)
                ? Environment.GetEnvironmentVariable("HOME")
                : Environment.ExpandEnvironmentVariables("%HOMEDRIVE%%HOMEPATH%");
            return path.Replace("~", home);
        }
    }
    class PrimeiroArquivo {
        public static void Executar() {
            var path = @"~/primeiro_arquivo.txt".ParseHome();

            if (!File.Exists(path)) {
                using (StreamWriter sw = File.CreateText(path)) {
                    sw.WriteLine("Criando o primeiro arquivo!");
                }
            }
            using (StreamWriter sw = File.AppendText(path)) {
                sw.WriteLine("Adicionando texto...");
            }
        }
    }
}
