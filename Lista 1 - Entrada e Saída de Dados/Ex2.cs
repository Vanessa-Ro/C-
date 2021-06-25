using System;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            float numero;

            Console.WriteLine("Digite um número real por favor: ");
                numero = float.Parse(Console.ReadLine());

            Console.WriteLine("Você digitou o número: " + numero);
        }
    }
}
