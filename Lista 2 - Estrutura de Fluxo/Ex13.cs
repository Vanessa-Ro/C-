using System;

namespace Ex13
{
    class Program
    {
        static void Main(string[] args)
        {
            double basema, baseme, altura, area;

            Console.WriteLine("Digite o valor da base maior: ");
                basema = double.Parse(Console.ReadLine());

            if (basema > 0)
            {
                Console.WriteLine("Digite o valor da base menor: ");
                baseme = double.Parse(Console.ReadLine());

                if (baseme > 0)
                {
                    Console.WriteLine("Digite o valor da altura: ");
                    altura = double.Parse(Console.ReadLine());

                    if (altura > 0)
                    {
                        area = ((basema + baseme) * altura) / 2;

                        Console.WriteLine("A área do trapézio é: " + area);
                    }
                    else
                        Console.WriteLine("Número Inválido, a altura não pode ser menor que zero!");
                }
                else
                    Console.WriteLine("Número Inválido, a base não pode ser menor que zero!");
            }
            else
                Console.WriteLine("Número Inválido, a base não pode ser menor que zero!");

        }
    }
}
