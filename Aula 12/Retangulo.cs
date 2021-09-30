using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex
{
    class Retangulo : Forma
    {
        private double altura;
        private double largura;


        public Retangulo(double altura, double largura)
        {
            Console.WriteLine("*** Retângulo ***");
            base.setCor("vermelho");
            this.altura = altura;
            this.largura = largura;
            Console.WriteLine("Área: " + this.calcularArea() + "\n");
        }

        public override double calcularArea()
        {
            return altura *largura;
        }
    }
}
