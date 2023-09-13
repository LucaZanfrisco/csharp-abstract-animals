using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    public abstract class Animale
    {

        public void dormi()
        {
            Console.WriteLine("Zzzzzzz.....");
        }
        public abstract void Verso();

        public abstract void CosaMangia();

        public abstract int numeroZampe();

        public void StampaZampe()
        {
            Console.WriteLine($"{this.GetType().Name} ha {this.numeroZampe()} zampe \n");
        }

    }
}
