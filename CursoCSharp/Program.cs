using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturaDeControle;
using CursoCSharp.ClassesEMetodos;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentários - Fundamentos", Comentarios.Executar },
                {"Variáveis e Constantes - Fundamentos", VariaveisEConstantes.Executar },
                {"Inferência - Fundamentos", Inferencia.Executar },
                {"Interpolação de Strings - Fundamentos", Interpolacao.Executar },
                {"Notação ponto - Fundamentos", NotacaoPonto.Executar },
                {"Lendo dados do console - Fundamentos", LendoDados.Executar },
                {"Formatando números - Fundamentos", FormatandoNumeros.Executar },
                {"Converssões - Fundamentos", Converssoes.Executar },
                {"Operadores Aritméticos - Fundamentos", OperadoresAritmeticos.Executar },
                {"Operadores Relacionais - Fundamentos", OperadoresRelacionais.Executar },
                {"Operadores Lógicos - Fundamentos", OperadoresLogicos.Executar },
                {"Operadores de Atribuição - Fundamentos", OperadoresAtribuicoes.Executar },
                {"Operadores Unários - Fundamentos", OperadoresUnarios.Executar },
                {"Operador Ternário - Fundamentos", OperadorTernario.Executar },
                
                //Estruturas de Controle
                {"IF - Estruturas de Controle", EstruturaIf.Executar },
                {"Switch - Estruturas de Controle", EstruturaSwitch.Executar },
                {"While - Estruturas de Controle", EstruturaWhile.Executar },
                {"Do while - Estruturas de Controle", EstruturaDoWhile.Executar },
                {"For - Estruturas de Controle", EstruturaFor.Executar },
                {"For Each - Estruturas de Controle", EstruturaForEach.Executar },

                //Classes e métodos
                {"Membros - Classes & Métodos", Membros.Executar}
            });

            central.SelecionarEExecutar();
        }
    }
}