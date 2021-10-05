using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex
{
    class Triangulo : IForma
    {
        private double baseT;
        private double altura;

        public Triangulo(double baseT, double altura)
        {
            Console.WriteLine("*** Triângulo ***");
            this.baseT = baseT;
            this.altura = altura;
        }

        public double calcularArea()
        {
            return (baseT * altura) / 2;
        }
    }
}
