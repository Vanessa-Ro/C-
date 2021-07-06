using System;

namespace Ex7
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario, vpe;

            Console.WriteLine("Digite o salário por favor: ");
                salario = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor da prestação do empréstimo: ");
                vpe = double.Parse(Console.ReadLine());

            if (vpe > salario * 0.20)
                Console.WriteLine("Empréstimo Não Concedido!");
            else
                Console.WriteLine("Empréstimo Concedido!");
        }
    }
}
