using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex
{
    class Circulo : Forma
    {
        private double raio;

        public Circulo(double raio)
        {
            Console.WriteLine("*** Círculo ***");
            base.setCor("Verde");
            this.raio = raio;
            Console.WriteLine("Área: " + this.calcularArea() + "\n");
        }

        public override double calcularArea()
        {
            return Math.Round((Math.PI * Math.Pow(raio, 2)), 1);
        }
    }


}
