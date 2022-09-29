using System;

namespace CursoCSharp.ExplorandoApi {
    class ExemploDateTime {
        public static void Executar() {
            var dateTime = new DateTime(2021, 8, 1);

            Console.WriteLine(dateTime.Day);
            Console.WriteLine(dateTime.Month);
            Console.WriteLine(dateTime.Year);

            //Sem horas
            var hoje = DateTime.Today;
            Console.WriteLine(hoje);

            //Com horas
            var diaAtual = DateTime.Now;
            Console.WriteLine(diaAtual);

            var amanha = diaAtual.AddDays(1);
            Console.WriteLine(amanha);

            Console.WriteLine(diaAtual.ToString("dd"));
            Console.WriteLine(diaAtual.ToString("d"));
            Console.WriteLine(diaAtual.ToString("D"));
            Console.WriteLine(diaAtual.ToString("g"));
            Console.WriteLine(diaAtual.ToString("G"));
            Console.WriteLine(diaAtual.ToString("dd-MM-yyyy HH:mm"));
        }
    }
}
