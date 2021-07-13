using System;

namespace Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;

            Console.WriteLine("Digite um número inteiro: ");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine("\nOs " + n + " primeiros números ímpares são: ");

            for (int i = 0; i <= n * 2; i++)
            {
                if(i % 2 != 0)
                    Console.WriteLine(i);  
            }
        }
    }
}
