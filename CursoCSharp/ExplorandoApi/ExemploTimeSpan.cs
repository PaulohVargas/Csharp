using System;

namespace CursoCSharp.ExplorandoApi {
    class ExemploTimeSpan {
        public static void Executar() {
            var intervalo = new TimeSpan(days: 10, hours: 20, minutes: 30, seconds: 40);
            Console.WriteLine(intervalo);

            Console.WriteLine("Intervalo em minutos: " + intervalo.TotalMinutes);

            var largada = DateTime.Now;
            var chegada = largada.AddMinutes(15);

            var tempo = chegada - largada;
            Console.WriteLine("\nTempo: " + tempo);

            //Não altera o original
            Console.WriteLine("\n" + intervalo.Add(TimeSpan.FromMinutes(10)));

            Console.WriteLine("\nTo String 1: " + intervalo.ToString("g"));
            Console.WriteLine("To String 2: " + intervalo.ToString("G"));
            Console.WriteLine("To String 3: " + intervalo.ToString("c"));

            Console.WriteLine("\nParse: " + TimeSpan.Parse("01:02:03").TotalMilliseconds);
        }
    }
}
