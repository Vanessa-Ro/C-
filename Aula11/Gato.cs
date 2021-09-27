using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex
{
    class Gato : Mamifero
    {
        public Gato()
        {
            
        }

        protected override void alimentacao()
        {
            base.alimentacao();
            Console.Write("Gato: Ração, frango, peixes, vegetais e frutas.\n\n");
        }
    }
}
