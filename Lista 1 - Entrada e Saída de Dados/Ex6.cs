using System;

namespace Ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            double celsius;
            double fahrenheit;

            Console.WriteLine("Digite a temperatura em Celsius a ser convertida para Fahrenheit: ");
                celsius = double.Parse(Console.ReadLine());

            fahrenheit = celsius * (9.0 / 5.0) + 32.0;

            Console.WriteLine("A temperatura de " + celsius + " graus Celsius equivale a " + fahrenheit + " graus Fahrenheit");
        }
    }
}
