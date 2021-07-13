using System;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;

            Console.WriteLine("Os cinco primeiros múltiplos de 3 são: ");

            for (int i = 1; i < 6; i++)
            {
                num = 3 * i;
                Console.WriteLine(num);
            }

        }
    }
}
