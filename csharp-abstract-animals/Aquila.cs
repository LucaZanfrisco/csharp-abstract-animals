using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    public class Aquila : Animale
    {
        public override void CosaMangia()
        {
            Console.WriteLine("volpi, lepri, marmotte, conigli selvatici e faine.");
        }

        public override void Verso()
        {
            Console.WriteLine("Graa graa!!");
        }
    }
}
