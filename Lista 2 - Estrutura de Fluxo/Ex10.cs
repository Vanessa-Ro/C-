using System;

namespace Ex10
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2, nota3, media;

            Console.WriteLine("Digite a nota da primeira prova: ");
                nota1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a nota da segunda prova: ");
                nota2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a nota da terceira prova: ");
                nota3 = double.Parse(Console.ReadLine());

            media = ((nota1 * 10) + (nota2 * 10) + (nota3 * 20)) / 4;

            if (media >= 60)
                Console.WriteLine("\nAPROVADO!");
            else
                Console.WriteLine("\nREPROVADO!");

            Console.WriteLine("\nMédia: " + Math.Round(media, 2) + " pontos");
           
        }
    }
}
