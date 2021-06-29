using System;

namespace SwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcao = "sim";

            switch (opcao)
            {
                case "sim":
                    Console.WriteLine("Você escolheu a opção SIM");
                    break;

                case "não":
                case "talvez":
                    Console.WriteLine("Você não escolheu a opção SIM");
                    break;

                default:
                    Console.WriteLine("Opção Inválida!");
                    break;
            }
        }
    }
}
