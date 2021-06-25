using System;

namespace Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            double num;
            double result;

            Console.WriteLine("Digite um número real: ");
                num = double.Parse(Console.ReadLine());

            result = Math.Pow(num, 2);

            Console.WriteLine("O resultado do quadrado do número digitado é: " + result);
        }
    }
}
