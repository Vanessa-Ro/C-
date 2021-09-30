using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex
{
    class Triangulo : Forma
    {
        private double baseT;
        private double altura;

        public Triangulo(double baseT, double altura)
        {
            Console.WriteLine("*** Triângulo ***");
            base.setCor("Amarelo");
            this.baseT = baseT;
            this.altura = altura;
            Console.WriteLine("Área: " + this.calcularArea() + "\n");
        }

        public override double calcularArea()
        {
            return (baseT * altura) / 2;
        }
    }
}
