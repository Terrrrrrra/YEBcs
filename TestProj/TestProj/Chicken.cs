using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TestProj
{
    internal class Chicken : Animal
    {
        public Chicken(string name, int leg, string sound)
        {
            Name = name;
            Leg = leg;
            Sound = sound;
        }
    }
}
