using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radio
{
    internal class Radio
    {
        public float Volume { get; set; }
        public float Aumentavolume()
        {
            return Volume+(10*Volume)/100;
        }
        public float Diminuiscivolume()
        {
            return Volume - (10 * Volume) / 100;
        }
    }
}
