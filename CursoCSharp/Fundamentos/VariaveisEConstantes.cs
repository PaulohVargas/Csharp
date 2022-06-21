using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    class VariaveisEConstantes {
        public static void Executar() {
            //Área  da circunferência
            double raio = 4.5;
            const double PI = 3.14;

            double area = PI * raio * raio;
            Console.WriteLine(area);
            Console.WriteLine("A área é: " + area);

            //Tipos internos
            bool estaChovendo = true;
            Console.WriteLine("Está choendo? " + estaChovendo);

            byte idade = 20; //só aceita valores positivos
            sbyte saldoDeGols = sbyte.MinValue; //aceita valores negativos
            Console.WriteLine("O saldo de gols é de: " + saldoDeGols);

            short salario = short.MaxValue;
            Console.WriteLine("O salário é de R$" + salario);

            int menorValorInt = int.MinValue; //tem sinal
            Console.WriteLine("O menor valor do inteiro é: " + menorValorInt);

            uint populacaoBrasil = 207_600_000; //n tem sinal, ou seja, apenas positivos
            Console.WriteLine("População Brasileira: " + populacaoBrasil);

            long menorValorLong = long.MinValue;//com sinal
            Console.WriteLine("Menor valor do long é:" + menorValorLong);

            ulong populacaoMundo = 7_600_000_000;//sem sinal
            Console.WriteLine("População mundial: " + populacaoMundo);

            float precoPc = 7200.99f;
            Console.WriteLine("O preço do PC é R$" + precoPc);

            decimal kmEstrelas = decimal.MaxValue;
            Console.WriteLine("A distância entre as estrelas é de: " + kmEstrelas + " Km");

            char letra = 'P'; //aspas simples para única letra

            string texto = "Seja bem vindo ao curso de C#!";
            Console.WriteLine(texto);

        }
    }
}
