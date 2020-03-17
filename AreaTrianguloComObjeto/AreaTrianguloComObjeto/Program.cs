using System;

namespace AreaTrianguloComObjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo a = new Triangulo(2, 4, 5);
            Triangulo b = new Triangulo(7, 8, 9);

            Console.WriteLine("Área Triangulo A: " + a.area().ToString("F4"));
            Console.WriteLine("Área Triangulo B: " + b.area().ToString("F4"));
        }
    }
}
