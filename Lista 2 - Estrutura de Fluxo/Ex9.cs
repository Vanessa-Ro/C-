using System;

namespace Ex9
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, aux = 0; 

            Console.WriteLine("Digite um número inteiro: ");
                num = int.Parse(Console.ReadLine());

            if (num > 0)
            {
                for (int i = 0; i < num + 1; i++)
                {
                    aux += num % 10;
                    num /= 10;
                }
                Console.WriteLine("A soma dos algarismos é: " + aux);
            }
            else
                Console.WriteLine("Número Inválido!");
           

        }
    }
}
