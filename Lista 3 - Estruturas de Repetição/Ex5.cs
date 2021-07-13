using System;

namespace Ex55
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;

            Console.WriteLine("Digite um número: ");
            num = int.Parse(Console.ReadLine());

            for (int i = num + 1; i <= num + 1; i++)
            {
                if ((i % 11 == 0) || (i % 13 == 0) || (i % 17 == 0))
                    Console.WriteLine(i);
                else
                    num += 1;

            }
        }
    }
}
