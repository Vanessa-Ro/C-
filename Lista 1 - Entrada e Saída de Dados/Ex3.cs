using System;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            float num1;
            float num2;
            float num3;
            float soma;
           
            Console.WriteLine("Digite três valores por favor: ");
                num1 = float.Parse(Console.ReadLine());
                num2 = float.Parse(Console.ReadLine());
                num3 = float.Parse(Console.ReadLine());

            soma = num1 + num2 + num3;

            Console.WriteLine("A soma dos números digitados é: " + soma);
        }
    }
}
