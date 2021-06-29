using System;

namespace Ex7
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;

            while (i < 10)
            {
                if (i == 5)
                {
                    i++;
                    continue;
                }

                Console.WriteLine(i);
                i++;
            }
        }
    }
}
