using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    public class Aquila : Animale, IVolante
    {
        public override void CosaMangia()
        {
            Console.WriteLine("volpi, lepri, marmotte, conigli selvatici e faine.");
        }

        public override int numeroZampe()
        {
            return 2;
        }

        public override void Verso()
        {
            Console.WriteLine("Graa graa!!");
        }

        public void Vola()
        {
            Console.WriteLine("Sto Volando!!");
        }

        public int NumeroAli()
        {
            return 2;
        }

    }
}
