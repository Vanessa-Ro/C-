using System;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;

            Console.WriteLine("Digite um número inteiro por favor: ");
                numero = int.Parse(Console.ReadLine());

            Console.WriteLine("Você digitou o número: " + numero);
        }
    }
}
