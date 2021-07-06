using System;

namespace Ex11
{
    class Program
    {
        static void Main(string[] args)
        {
            double tl, avas, exf, media;

            Console.WriteLine("A seguir você digitará as notas para o cálculo da média, digite notas somente entre 0 e 10\n");

            Console.WriteLine("Digite a nota do Trabalho de Laboratório: ");
                tl = double.Parse(Console.ReadLine());

            if (tl >= 0 && tl <= 10)
            {
                Console.WriteLine("Digite a nota da Avaliação Semestral: ");
                    avas = double.Parse(Console.ReadLine());

                if (avas >= 0 && avas <= 10)
                {
                    Console.WriteLine("Digite a nota do Exame Final: ");
                        exf = double.Parse(Console.ReadLine());

                    if (exf >= 0 && exf <= 10)
                    {
                        media = ((tl * 2) + (avas * 3) + (exf * 5)) / 10;

                        if (media < 3)
                            Console.WriteLine("\nREPROVADO :(");
                        else if (media < 5)
                            Console.WriteLine("\nRECUPERAÇÃO :|");
                        else
                            Console.WriteLine("\nAPROVADO :)");

                        Console.WriteLine("\nMédia: " + Math.Round(media, 2));
                    }
                    else
                        Console.WriteLine("Você digitou uma nota inválida, digite notas apenas entre 0 e 10");
                }
                else
                    Console.WriteLine("Você digitou uma nota inválida, digite notas apenas entre 0 e 10");
            }
            else
                Console.WriteLine("Você digitou uma nota inválida, digite notas apenas entre 0 e 10");
        }
    }
}
