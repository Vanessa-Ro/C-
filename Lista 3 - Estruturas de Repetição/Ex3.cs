using System;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            double valores, soma = 0;

            Console.WriteLine("Digite 10 valores: ");
                

            for (int i = 0; i < 10; i++)
            {
                valores = double.Parse(Console.ReadLine());
                
                soma += valores;
            }
            Console.WriteLine("A soma dos valores digitados é: " + soma);



        }
    }
}
