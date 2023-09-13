using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    public class Passerotto : Animale
    {
        public override void CosaMangia()
        {
            Console.WriteLine("Fiocchi d'avena, frutta, uvetta, noce e nocciole");
        }

        public override void Verso()
        {
            Console.WriteLine("Cip Cip!!");
        }
    }
}
