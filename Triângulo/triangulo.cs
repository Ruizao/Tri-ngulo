using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triângulo
{
    class triangulo
    {
        public ponto P1 = new ponto();
        public ponto P2 = new ponto();
        public ponto P3 = new ponto();
        public double Perimetro => P1.Triangulo(P2) + P2.Triangulo(P3) + P3.Triangulo(P1);
        public double Area
        {
            get
            {
                double s = this.Perimetro/2;
                double a = P1.Triangulo(P2);
                double b = P2.Triangulo(P3);
                double c = P3.Triangulo(P1);
                double T = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
                return T;
            }
        }
    
    }
}
