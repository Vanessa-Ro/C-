using System;

namespace Ex
{
    class Program
    {
        static void mostrarArea(IForma forma)
        {
            Console.WriteLine("Área: " + forma.calcularArea() + "\n");
        }

        static void Main(string[] args)
        {
            IForma forma = new Quadrado(10.0);
            mostrarArea(forma);

            forma = new Retangulo(10.0, 5.0);
            mostrarArea(forma);

            forma = new Triangulo(5.0, 4.0);
            mostrarArea(forma);

            forma = new Circulo(5.0);
            mostrarArea(forma);
        }

    }
}
