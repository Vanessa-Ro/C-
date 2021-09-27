using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex
{
    class Cachorro : Mamifero
    {
        public Cachorro()
        {
           
        }

        protected override void alimentacao()
        {
            base.alimentacao();
            Console.Write("Cachorro: Ração, carnes, vegetais, frutas e grãos.\n\n");
        }
    }
}
