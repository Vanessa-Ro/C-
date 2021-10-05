﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex
{
    class Quadrado : IForma
    {
        private double lado;

        public Quadrado(double lado)
        {
            Console.WriteLine("*** Quadrado ***");
            this.lado = lado;
        }

        public double calcularArea()
        {
            return lado * lado;
        }
    }
}
