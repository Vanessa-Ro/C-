using System;

namespace Ex7
{
    class Program
    {
        static void Main(string[] args)
        {
            double fahrenheit;
            double celsius;
            
            Console.WriteLine("Digite a temperatura em Fahrenheit a ser convertida para Celsius: ");
                fahrenheit = double.Parse(Console.ReadLine());

            celsius = 5.0 * (fahrenheit - 32.0) / 9.0;

            Console.WriteLine("A temperatura de " + fahrenheit + " graus Fahrenheit equivale a " + celsius + " graus Celsius");
        }
    }
}
