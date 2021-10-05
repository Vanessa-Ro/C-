using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex
{
    class Circulo : IForma
    {
        private double raio;

        public Circulo(double raio)
        {
            Console.WriteLine("*** Círculo ***");
            this.raio = raio;
        }

        public double calcularArea()
        {
            return Math.Round((Math.PI * Math.Pow(raio, 2)), 1);
        }
    }
}
