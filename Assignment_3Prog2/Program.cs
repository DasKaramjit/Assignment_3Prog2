using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3Prog2
{
    class Program
    {
        static void Main(string[] args)
        {
            GiantPlanet giantPlanet = new GiantPlanet("Jupiter", 45668, 4567, "Gas");
            Console.WriteLine(giantPlanet.ToString());
            Terrestialplanet terrestialPlanet = new Terrestialplanet("Earth", 6545, 3453, (true ));
            Console.WriteLine(terrestialPlanet.ToString());

        }

        private static void AnyKeyClose()
        {
            Console.ReadLine();
        }
    }
}
