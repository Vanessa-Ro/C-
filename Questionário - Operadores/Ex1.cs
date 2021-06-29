using System;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
			float a = 8, b = 6;
			float resultado;

			resultado = a + b;
			Console.WriteLine("Soma: " + resultado);

			resultado = a - b;
			Console.WriteLine("Subtração: " + resultado);

			resultado = a * b;
			Console.WriteLine("Multiplicação: " + resultado);

			resultado = a / b;
			Console.WriteLine("Divisão: " + resultado);

			resultado = a % b;
			Console.WriteLine("Resto de divisão: " + resultado);

		}
	}
}
