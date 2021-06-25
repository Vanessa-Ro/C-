using System;

namespace Ex8
{
    class Program
    {
        static void Main(string[] args)
        {
            double kelvin;
            double celsius;

            Console.WriteLine("Digite a temperatura em Kelvin a ser convertida para Celsius: ");
                kelvin = double.Parse(Console.ReadLine());

            celsius = kelvin - 273.15;

            Console.WriteLine("A temperatura de " + kelvin + " graus Kelvin equivale a " + celsius + " graus Celsius");
        }
    }
}
