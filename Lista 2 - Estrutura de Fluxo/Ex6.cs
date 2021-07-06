using System;

namespace Ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2, media;

            Console.WriteLine("Digite a primeira nota: ");
                nota1 = double.Parse(Console.ReadLine());


            if (nota1 >= 0.0 && nota1 <= 10.0)
            {
                Console.WriteLine("\nA nota digitada é válida!\n");

                Console.WriteLine("Digite a segunda nota: ");
                nota2 = double.Parse(Console.ReadLine());

                if (nota2 >= 0.0 && nota2 <= 10.0)
                {
                    Console.WriteLine("\nA nota digitada é válida!\n");

                    media = (nota1 + nota2) / 2;

                    Console.WriteLine("A média das notas é: " + media);
                }
            }

            else
                Console.WriteLine("A nota digitada é inválida!");
        }
    }
}
