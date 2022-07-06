using System;

namespace CursoCSharp.ClassesEMetodos {

    class Carro {
        public string Fabricante;
        public string Modelo;
        public int Ano;
        public Carro() {
        }
        public Carro(string fabricante, string modelo, int ano) {
            Fabricante = fabricante;
            Modelo = modelo;
            Ano = ano;
        }   
    }
    class Construtores {
        public static void Executar() {
            var car = new Carro();
            car.Fabricante = "BMW";
            car.Modelo = "320M";
            car.Ano = 2021;

            Console.WriteLine($"{car.Fabricante} | {car.Modelo} | {car.Ano}");

            var car2 = new Carro("VW", "Cruze", 2014);
            Console.WriteLine($"{car2.Fabricante} | {car2.Modelo} | {car2.Ano}");
        }
    }
}
