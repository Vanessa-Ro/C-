﻿using System;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;

            Console.WriteLine("Digite um número por favor: ");
                num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
                Console.WriteLine("O número " + num + " é par");
            else
                Console.WriteLine("O número " + num + " é ímpar");
        }
    }
}
