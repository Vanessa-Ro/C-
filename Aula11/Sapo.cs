using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex
{
    class Sapo : Anfibio
    {
        public Sapo()
        {
           
        }

        protected override void alimentacao()
        {
            base.alimentacao();
            Console.Write("Sapo: Insetos e animais invertebrados.\n\n");
        }
    }
}
