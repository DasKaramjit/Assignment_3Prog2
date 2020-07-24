using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3Prog2
{
    class Terrestialplanet : Planet
    {
        //private instance fields
        bool m_oxygen;

        //constructor
        public Terrestialplanet(string name, double diameter, double mass, bool oxygen) 
            : base(name, diameter, mass)
        {
            m_oxygen = oxygen;
        }

        //methods
        public bool HasMoons()
        {
            if (Mooncount > 0)
            {
                return true;
            }
           else return false;
        }
        public bool Habitable()
        {
            if (m_oxygen ==true)
            {
                return  true;
            }
            
           else  return false;
        }
    }
}
