using System;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
			int x = 8, y = 6;

			if (x == y)
				Console.WriteLine("Os operandos são iguais.");
			else
				Console.WriteLine("Os operandos são diferentes.");

			if (x != y)
				Console.WriteLine("Os operandos são diferentes.");
			else
				Console.WriteLine("Os operandos são iguais.");

			if (x > y)
				Console.WriteLine("O primeiro operando é maior que o segundo operando.");
			else
				Console.WriteLine("O segundo operando é maior que o primeiro operando.");
		}
    }
}
