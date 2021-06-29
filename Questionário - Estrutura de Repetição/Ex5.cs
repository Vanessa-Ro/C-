using System;

namespace Ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;

            while (i < 10)
            {
                if (i == 5)
                    break;

                Console.WriteLine(i);
                i++;
            }
        }
    }
}
