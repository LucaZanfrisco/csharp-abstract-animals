using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    public class Delfino : Animale
    {
        public override void CosaMangia()
        {
            Console.WriteLine("pesce, crostacei e calamari");
        }

        public override void Verso()
        {
            Console.WriteLine("Fiu Fiu!!");
        }

        public override int numeroZampe()
        {
            return 0;
        }
    }
}
