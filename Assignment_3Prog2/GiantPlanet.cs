namespace Assignment_3Prog2
{
    internal class GiantPlanet : Planet
    {
        // private instance fields
        private string m_type;

        //constructor
        public GiantPlanet(string name, double diameter, double mass, string type)
            : base(name, diameter, mass)
        {
            m_type = type;
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

        public bool HasRings()
        {
            if (RingCount > 0)
            {
                return true;
            }
            else return false;
        }
        public override string ToString()
        {

            string outputString = "";
            outputString += $"************************* \n";
            outputString += $"Name     :  {Name}        \n";
            outputString += $"Diameter :  {Diameter}    \n";
            outputString += $"Mass     :  {Mass}        \n";
            outputString += $"Type     :  {m_type}      \n";
            outputString += $"************************* \n";
            
            
            return outputString;
        }
    }
}