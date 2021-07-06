using System;

namespace Ex12
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao; 

            Console.WriteLine("Digite um número entre 1 e 7: ");
                opcao = int.Parse(Console.ReadLine());

            if (opcao >= 1 && opcao <= 7)
            {
                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Domingo");
                        break;

                    case 2:
                        Console.WriteLine("Segunda-Feira");
                        break;

                    case 3:
                        Console.WriteLine("Terça-Feira");
                        break;

                    case 4:
                        Console.WriteLine("Quarta-Feira");
                        break;

                    case 5:
                        Console.WriteLine("Quinta-Feira");
                        break;

                    case 6:
                        Console.WriteLine("Sexta-Feira");
                        break;

                    case 7:
                        Console.WriteLine("Sábado");
                        break;
                }
            }
            else
                Console.WriteLine("Número Inválido!");
        }
    }
}
