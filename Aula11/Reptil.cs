using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex
{
    class Reptil : Animal
    {
        public Reptil()
        {
            this.alimentacao();
        }

        protected override void alimentacao()
        {
            base.alimentacao();
            Console.Write("Réptil: Carnívoros ou Herbívoros.\n\n");
        }
    }
}
