using System;

namespace IfElse
{
    class Program
    {
        static void Main(string[] args)
        {
            double p1 = 10;
            double p2 = 8.5;
            double media = 0;
            string desempenho;

            media = (p1 + p2) / 2;

            if (media <= 5)
                desempenho = "INSATISFATÓRIO :(";
           
            else if (media <= 7)
                desempenho = "REGULAR :|";
           
            else if (media <= 8.5)
                desempenho = "BOM!";
            else
                desempenho = "ÓTIMO!!!";

            Console.WriteLine("O desempenho do aluno foi: " + desempenho);

        }
    }
}
