﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {
    class Pessoa {
        public string Nome;
        public int Idade;

        public string Apresentacao() {
            return string.Format($"{Nome} tem {Idade} anos!");
        }
    }
}
