using System;

namespace Ex14
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;

            Console.WriteLine("Digite o valor de A: ");
                a = double.Parse(Console.ReadLine());

            if (a > 0)
            {
                Console.WriteLine("Digite o valor de B: ");
                    b = double.Parse(Console.ReadLine());

                if (b > 0)
                {
                    Console.WriteLine("Digite o valor de C: ");
                        c = double.Parse(Console.ReadLine());

                    if (c > 0)
                    {
                        if ((a < (b + c)) || (b < (a + c)) || (c < (a + b)))
                        {
                            if (a == b && b == c && c == a)
                                Console.WriteLine("Triângulo Equilátero");
                            else if (a == b || b == c || c == a)
                                Console.WriteLine("Triângulo Isóceles");
                            else if (a != b && b != c && c != a)
                                Console.WriteLine("Triângulo Escaleno");   
                        }
                        else
                            Console.WriteLine("Os valores digitados não formam um triângulo válido");
                    }
                    else
                        Console.WriteLine("Este valor é inválido para o lado de um triângulo!");
                }
                else
                    Console.WriteLine("Este valor é inválido para o lado de um triângulo!");
            }
            else
                Console.WriteLine("Este valor é inválido para o lado de um triângulo!");
        }
    }
}
