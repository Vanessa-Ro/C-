using System;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
			int media = 10;
			int presenca = 98;

			if ((media >= 6) && (presenca >= 75))
				Console.WriteLine("Aprovado!!!");
			else
				Console.WriteLine("Reprovado :(");


			string desempenho = "ótimo";

			if ((desempenho == "ótimo") || (desempenho == "bom"))
				Console.WriteLine("Aprovado!!!");
			else
				Console.WriteLine("Reprovado :(");


			int nota = 6;

			if (!(nota == 10))
				Console.WriteLine("A nota do aluno(a) foi: 10");
			else
				Console.WriteLine("A nota do aluno(a) foi: 6");
		}
    }
}
