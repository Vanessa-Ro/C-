using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex
{
    class Retangulo : IForma
    {
        private double altura;
        private double largura;


        public Retangulo(double altura, double largura)
        {
            Console.WriteLine("*** Retângulo ***");
            this.altura = altura;
            this.largura = largura;
        }

        public double calcularArea()
        {
            return altura * largura;
        }
    }
}
