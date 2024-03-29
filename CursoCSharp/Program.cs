﻿using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturaDeControle;
using CursoCSharp.ClassesEMetodos;
using CursoCSharp.Colecoes;
using CursoCSharp.OO;
using CursoCSharp.MetodosEFuncoes;
using CursoCSharp.Excecoes;
using CursoCSharp.ExplorandoApi;
using CursoCSharp.TopicosAvancados;

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
                {"Membros - Classes & Métodos", Membros.Executar},
                {"Construtores - Classes & Métodos", Construtores.Executar},
                {"Métodos com Retorno - Classes & Métodos", MetodosComReturn.Executar},
                {"Desafio - Classes & Métodos", Desafio.Executar},
                {"Params - Classes & Métodos", Params.Executar},
                {"Parâmetros Nomeados - Classes & Métodos", ParâmetrosNomeados.Executar},
                {"Get & Set - Classes & Métodos", GetSet.Executar},
                {"Props - Classes & Métodos", Props.Executar},
                {"Readonly - Classes & Métodos", Readonly.Executar},
                {"Enum - Classes & Métodos", ExemploEnum.Executar},
                {"Struct - Classes & Métodos", ExemploStruct.Executar},
                {"Struct vs Classe- Classes & Métodos", ClasseVSStruct.Executar},

                //Coleções
                {"Array - Coleções", Colecoes.Array.Executar},
                {"List - Coleções", Colecoes.List.Executar},
                {"Arraylist - Coleções", ExArrayList.Executar},
                {"Set - Coleções", ExHashSet.Executar},
                {"Queue - Coleções", ExQueue.Executar},
                {"Igualdade - Coleções", Igualdade.Executar},
                {"Stack - Coleções", ExStack.Executar},
                {"Dicionários - Coleções", Dicionario.Executar},

                //Orientação a Objeto
                {"Herança - OO", Heranca.Executar},
                {"Construtor This - OO", ConstrutorThis.Executar},
                {"Encapsulamento - OO", OO.Encapsulamento.Executar},
                {"Polimorfismo - OO", Polimorfismo.Executar},
                {"Classe abstrata - OO", Abstract.Executar},
                {"Interface - OO", Interface.Executar},
                {"Sealed - OO", Seaaled.Executar},

                //Métodos & Funções
                {"Exemplo Lambda - Métodos & Funções", ExemploLambda.Executar},
                {"Delegate - Métodos & Funções", LambdasDelegate.Executar},
                {"Delegate como função anônima - Métodos & Funções", DelegateFunAnonima.Executar},
                {"Delegate como parâmetros - Métodos & Funções", DelegateComoParametro.Executar},
                {"Métodos de Extenssão - Métodos & Funções", MetodosDeExtensao.Executar},

                //Exceções
                {"Primeira Exceção - Exceções", PrimeiraExcessao.Executar},
                {"Exceção personalizada - Exceções", ExcecaoPersonalizada.Executar},

                //Explorando API
                {"Primeiro Arquivo - Explorando API", PrimeiroArquivo.Executar},
                {"Lendo arquivo - Explorando API", LendoArquivo.Executar},
                {"Exemplo FileInfo - Explorando API", ExemploFileInfo.Executar},
                {"Diretórios - Explorando API", Diretorios.Executar},
                {"DirectoryInfo - Explorando API", ExemploDirectoryInfo.Executar},
                {"Path - Explorando API", ExemploPath.Executar},
                {"Exemplo DateTime - Explorando API", ExemploDateTime.Executar},
                {"Exemplo TimeSpan - Explorando API", ExemploTimeSpan.Executar},

                //Tópicos avançados
                {"LINQ #1 - Tópicos Avançados", LINQ1.Executar},
                {"LINQ #2 - Tópicos Avançados", LINQ2.Executar},
                {"Nullable - Tópicos Avançados", Nullables.Executar},
                {"Dynamic - Tópicos Avançados", Dynamics.Executar},
                {"Genéricos - Tópicos Avançados", Genericos.Executar},
            }); ;

            central.SelecionarEExecutar();
        }
    }
}