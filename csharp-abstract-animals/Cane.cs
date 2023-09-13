﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    public class Cane : Animale
    {
        public override void CosaMangia()
        {
            Console.WriteLine("carne, pesce, frutta, croccantini");
        }

        public override void Verso()
        {
            Console.WriteLine("Bau Bau!!");
        }

        public override int numeroZampe()
        {
            return 4;
        }
    }
}
