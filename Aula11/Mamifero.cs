using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex
{
    class Mamifero : Animal
    {
        public Mamifero()
        {
            this.alimentacao();
        }

        protected override void alimentacao()
        {
            base.alimentacao();
            Console.Write("Mamíferos: Carnívoros, Herbívoros ou Onívoros.\n\n");
        }
    }
}
