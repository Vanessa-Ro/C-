using System;

namespace Ex15
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade, temps;

            Console.WriteLine("Digite a sua idade: ");
                idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o tempo de serviço: ");
                temps = int.Parse(Console.ReadLine());

            if (idade >= 65 || temps >= 30 || (idade >= 60 && temps >= 25))
                Console.WriteLine("Aposentadoria concedida");
            else
                Console.WriteLine("Aposentadoria recusada, idade ou tempo de serviço insuficientes");

        }
    }
}
