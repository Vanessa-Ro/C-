using System;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Utilizando FOR: ");

            for(int i = 1; i < 101; i++)
                Console.WriteLine(i);

            Console.WriteLine("\n\nUtilizando WHILE: ");

            int x = 0;
            while (x < 100){
                x++;
                Console.WriteLine(x);
            }

            Console.WriteLine("\n\nUtilizando DO-WHILE: ");

            int y = 0;
            do
            {
                y++;
                Console.WriteLine(y);
            } while (y < 100);
        }
    }
}
