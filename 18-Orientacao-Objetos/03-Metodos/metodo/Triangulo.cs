using System;

namespace metodo
{
    class Triangulo
    {
        public double A;
        public double B;
        public double C;

        public double Area()
        {
            double p = (A + B + C) / 2.0;
            //double raiz = Math.Sqrt(p * (p - A) * p * (p - B) * p * (p - C));
            //return raiz;

            //ou pode retornar direto sem usar variavel
            return Math.Sqrt(p * (p - A) * p * (p - B) * p * (p - C));
        }
    }
}
