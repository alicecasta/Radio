using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Radio radio = new Radio();
            Console.WriteLine("inserie un volume");
            radio.Volume= float.Parse(Console.ReadLine());
            Console.WriteLine("il volume può aumentato fino a {0} e può diminuire fino a {1}", radio.Aumentavolume(), radio.Diminuiscivolume());
            Console.ReadLine();
        }
    }
}
