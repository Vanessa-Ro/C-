using System;

namespace Ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            float num;
            float result;

            Console.WriteLine("Digite um número real: ");
                num = float.Parse(Console.ReadLine());

            result = num / 5;

            Console.WriteLine("A quinta parte do número " + num + " é: " + result);
        }
    }
}
