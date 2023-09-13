using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    public class Passerotto : Animale, IVolante
    {
        public override void CosaMangia()
        {
            Console.WriteLine("Fiocchi d'avena, frutta, uvetta, noce e nocciole");
        }

        public override void Verso()
        {
            Console.WriteLine("Cip Cip!!");
        }

        public override int numeroZampe()
        {
            return 2;
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
