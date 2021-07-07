using System;

namespace Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] dadosAlunos = new string[3, 4];

            int i = 0, j = 0;

            for (i = 0; i < 3; i++)
            {
                Console.WriteLine("Lendo informações do " + (i + 1) + "º aluno: ");

                for(j = 0; j < 4; j++)
                {
                    Console.WriteLine("Digite dados[" + i + ", " + j + "]: ");
                    dadosAlunos[i, j] = Console.ReadLine();
                }
            }
        }
    }
}
