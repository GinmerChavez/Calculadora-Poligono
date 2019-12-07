﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UNA.Poligonos
{
    public class Pentagono : UNA.Poligonos.Poligono
    {
        public double Lado
        {
            get;
            set;

        }

        public double Apotema
        {
            get;
            set;

        }

            public double NumeroLado
        {
            get;
            set;

        }



        public override double CalcularArea()
        {
            return (CalcularPerimetro() * Apotema) / 2;
        }

        

        public override double CalcularPerimetro()
        {
            return NumeroLado * Lado;
        }
    }
}