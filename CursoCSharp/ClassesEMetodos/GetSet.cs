using System;

namespace CursoCSharp.ClassesEMetodos {

    public class Moto {
        private string Marca;
        private string Modelo;
        private int Cilindrada;

        public Moto(string marca, string modelo, int cilindrada) {
            //Marca = marca;
            //Modelo = modelo;
            //Cilindrada = cilindrada;
            SetMarca(marca);
            SetModelo(modelo);
            SetCilindrada(cilindrada);
        }
        public Moto() {
        }

        public string GetMarca() {
            return Marca;
        }
        public void SetMarca(string marca) {
            Marca = marca;
        }
        public string GetModelo() {
            return Modelo;
        }
        public void SetModelo(string modelo) {
            Modelo = modelo;
        }
        public int getCilindrada() {
            return Cilindrada;
        }
        public void SetCilindrada(int cilindrada) {
            if (cilindrada > 0) {
                Cilindrada = cilindrada;
            }
        }
    }

    class GetSet {
        public static void Executar() {
            var moto1 = new Moto("Honda", "CG", 160);
            Console.WriteLine(moto1.GetMarca() + " " + moto1.GetModelo() + " " + moto1.getCilindrada());

            var moto2 = new Moto();
            moto2.SetMarca("Yamaha");
            moto2.SetModelo("XJ");
            moto2.SetCilindrada(600);
            Console.WriteLine(moto2.GetMarca() + " " + moto2.GetModelo() + " " + moto2.getCilindrada());
        }
    }
}
