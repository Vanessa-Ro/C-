using System;

namespace Ex8
{
    class Program
    {
        static void Main(string[] args)
        {
            double altura, peso;
            int sexo;

            Console.WriteLine(" Qual o seu sexo?\n Homem - digite 1\n Mulher - digite 2\n");
                sexo = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite sua altura: ");
                altura = double.Parse(Console.ReadLine());

            if (sexo == 1)
            {
                peso = ((72.7 * altura) - 58);
                Console.WriteLine("Seu peso ideal é: " + Math.Round(peso, 2) + "Kg");
            }

            else
            {
                peso = ((62.1 * altura) - 44.7);
                Console.WriteLine("Seu peso ideal é: " + Math.Round(peso, 2) + "Kg");
            }
        }
    }
}
