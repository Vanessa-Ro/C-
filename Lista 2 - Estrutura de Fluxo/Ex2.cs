using System;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            double num;

            Console.WriteLine("Digite um número por favor: ");
                num = int.Parse(Console.ReadLine());

            if (num > 0) { 
                double pot = Math.Pow(num, 2);
                double raiz = Math.Sqrt(num);

                Console.WriteLine("O número " + num + " ao quadrado é: " + pot + " e sua raiz quadrada é: " + raiz);
            }
            else
                Console.WriteLine("O número " + num + " é negativo");
                
        }
    }
}
