using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3Prog2
{

    /* Name : Das Karamjit
     * Student ID : 301108505
     * Date Last Modified : 24-7-2020
     * Program Description : This is the program based on abstract classes and interface where Planet is abstract class
     * and it has 2 subclasses, 3 interfaces and 1 program.cs file.
     * Revision History : Program is  revised several times to check for errors.
     */
    class Program
    {
        static void Main(string[] args)
        {
            GiantPlanet giantPlanet = new GiantPlanet("Jupiter", 45668, 4567, "Gas");
            Console.WriteLine(giantPlanet.ToString());
            Terrestialplanet terrestialPlanet = new Terrestialplanet("Earth", 6545, 3453, (true ));
            Console.WriteLine(terrestialPlanet.ToString());

        }
        // to let user enter key to exit
        private static void AnyKeyClose()
        {
            Console.ReadLine();
        }
    }
}
