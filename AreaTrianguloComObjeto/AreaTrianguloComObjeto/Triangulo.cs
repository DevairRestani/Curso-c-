using System;

namespace AreaTrianguloComObjeto
{
    class Triangulo
    {
        private double A;
        private double B;
        private double C;

        public Triangulo(){ }

        public Triangulo(double a, double b, double c)
        {
            this.A = a;
            this.B = b;
            this.C = c;
        }

        public void setA(double a)
        {
            this.A = a;
        }

        public void setB(double b)
        {
            this.B = b;
        }

        public void setC(double c)
        {
            this.C = c;
        }

        public void setLados(double a, double b, double c)
        {
            this.A = a;
            this.B = b;
            this.C = c;
        }

        public double area()
        {
            double p = (this.A + this.B + this.C) / 2;
            return Math.Sqrt(p * (p - this.A) * (p - this.B) * (p - this.C));
        }
    }
}
