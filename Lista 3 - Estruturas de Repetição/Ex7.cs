using System;

namespace Ex7
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, aux;

            Console.WriteLine("Digite um número inteiro: ");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine("\nOs " + n + " primeiros números pares são: ");

            for (int i = 0; i <= n; i++)
            {
                if (i % 2 == 0)
                    Console.WriteLine(i);
            }
        }
    }
}
