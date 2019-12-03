﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triângulo
{
    class ponto
    {
        private double _X, _Y, _Z;
        public double X { set => _X = value; get => _X; }
        public double Y { set => _Y = value; get => _Y; }
        public double Z { set => _Z = value; get => _Z; }

        public double Triangulo(ponto P) =>
        Math.Sqrt(Math.Pow(P.X - _X, 2) + Math.Pow(P.Y - _Y, 2) + Math.Pow(P.Z - _Z, 2));

    }
}
