using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UNA.Poligonos
{
    public class Rectangulo : Poligono
    {
        public double Base
        {
            get;
            set;

        }

        public double Altura
        {
            get;
            set;

        }

        public override double CalcularPerimetro()
        {
            return 2 * Base + 2 * Altura;
        }

        public override double CalcularArea()
        {
            return Base * Altura;
        }
    }
}