using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista10_Cal_.src
{
    public class Quadrado : Formas
    {
        public Quadrado(string _nome, double _base, double _altura) : base(_nome, _base, _altura)
        {
        }

        public override double CalcularArea()
        {
            double area = Base * Altura;
            return area;
        }
    }
}