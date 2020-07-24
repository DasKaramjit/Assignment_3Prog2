using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3Prog2
{
    abstract class Planet
    {
        // Private instance variable

        private double m_diameter;
        private double m_mass;
        private int m_moonCount;
        private string m_name;
        private double m_orbitalPeriod;
        private int m_ringCount;
        private double m_rotationPeriod;

        // Public properties

        public double Diameter 
        {
            get
            {
                return m_diameter;
            }
                
        }
        public double Mass
        {
            get
            {
                return m_mass;
            }

        }
        public string Name
        {
            get
            {
                return m_name;
            }

        }
        public double Mooncount
        {
            get
            {
                return m_moonCount;
            }

        }
        public double RotationPeriod 
        {
            get
            {
                return m_rotationPeriod;
            }
            set
            {
                m_rotationPeriod = value;
            }
        }
        public int RingCount
        {
            get
            {
                return m_ringCount;
            }
            set
            {
                m_ringCount = value;
            }
        }
        public double OrbitalPeriod
        {
            get
            {
                return m_orbitalPeriod;
            }
            set
            {
               m_orbitalPeriod = value;
            }
        }

        // constructor

        public Planet(string name, double diameter,double mass)
        {
            m_name = name;
            m_diameter = diameter;
            m_mass = mass;
        }

        public override string ToString()
        {

            string outputString = "";
            outputString += $"************************* \n";
            outputString += $"Name     :  {Name}        \n";
            outputString += $"Diameter :  {Diameter}    \n";
            outputString += $"Mass     :  {Mass}        \n";
            outputString += $"************************* \n";

            return outputString;
        }
    }
}
