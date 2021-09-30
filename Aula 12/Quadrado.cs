using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex
{
    class Quadrado : Forma
    {
        private double lado;

        public Quadrado(double lado)
        {
            Console.WriteLine("*** Quadrado ***");
            base.setCor("Azul");
            this.lado = lado;
            Console.WriteLine("Área: " + this.calcularArea() + "\n");
        }

        public override double calcularArea()
        {
            return lado * lado;
        }
    }
}
