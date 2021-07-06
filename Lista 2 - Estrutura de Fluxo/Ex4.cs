using System;

namespace Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, dif;

            Console.WriteLine("Digite dois números por favor: ");
                num1 = int.Parse(Console.ReadLine());
                num2 = int.Parse(Console.ReadLine());

            if (num1 > num2)
            {
                dif = num1 - num2;

                Console.WriteLine(num1 + " é maior que " + num2 + " e a difrença entre ambos é: " + dif);
            }
            else
            {
                dif = num2 - num1;

                Console.WriteLine(num2 + " é maior que " + num1 + " e a difrença entre ambos é: " + dif);
            }
        }
    }
}
