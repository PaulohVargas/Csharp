using System;

namespace CursoCSharp.ClassesEMetodos {
    interface Ponto {
        void moverDiagonal(int delta);
    }

    struct Coordenada : Ponto {
        public int X;
        public int Y;

        public Coordenada(int x, int y) {
            X = x; Y = y;
        }
        public void moverDiagonal(int delta) {
            X += delta; Y += delta;
        }
    }

    class ExemploStruct {
        public static void Executar() {
            Coordenada coordenadaInicial;
            coordenadaInicial.X = 2;
            coordenadaInicial.Y = 5;

            Console.WriteLine($"X = {coordenadaInicial.X} ; Y = {coordenadaInicial.Y}");

            var cFinal = new Coordenada(9,6);
            cFinal.moverDiagonal(10);

            Console.WriteLine($"X = {cFinal.X} ; Y = {cFinal.Y}");

        }
    }
}
