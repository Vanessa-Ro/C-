using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex
{
    class Jacare : Reptil
    {
        public Jacare()
        {
            
        }

        protected override void alimentacao()
        {
            base.alimentacao();
            Console.Write("Jacaré: Peixes, aves, répteis e mamíferos.\n\n");
        }
    }
}
