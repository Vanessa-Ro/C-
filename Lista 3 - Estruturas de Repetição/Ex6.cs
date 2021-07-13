using System;

namespace Ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, maior, menor;

            Console.WriteLine("Digite um número inteiro positivo ou um número inteiro negativo para sair: ");
                num = int.Parse(Console.ReadLine());

            maior = num;
            menor = num; 

            
            while (num >= 0){

                Console.WriteLine("Digite um número inteiro positivo ou um número inteiro negativo para sair: ");
                    num = int.Parse(Console.ReadLine());

                if (num >= 0)
                {
                    if (num > maior)
                        maior = num;
                    else 
                        menor = num;
                }
            } 

            Console.WriteLine(maior + " é o maior número digitado.");
            Console.WriteLine(menor + " é o menor número digitado.");
        }
    }
}
