﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista10_Cal_.src
{
    public abstract class Formas
    {
        public string Nome { get; set; }
        public double Base { get; set; }
        public double Altura { get; set; }

        public Formas(string _nome, double _base, double _altura)
        {
            Nome = _nome;
            Base = _base;
            Altura = _altura;
        }

        public abstract double CalcularArea();
    }
}