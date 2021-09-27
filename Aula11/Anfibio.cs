using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex
{
    class Anfibio : Animal
    {
        public Anfibio()
        {
            this.alimentacao();
        }

        protected override void alimentacao()
        {
            base.alimentacao();
            Console.Write("Anfíbios: Carnívoros ou Herbívoros.\n\n");
        }
    }
}
