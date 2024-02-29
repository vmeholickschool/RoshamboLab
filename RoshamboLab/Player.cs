using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Create an abstract class named Player that stores a name and a Roshambo value.
//This class should include a method named GenerateRoshambo
//that allows an inheriting class to generate and return a Roshambo value.

namespace RoshamboLab
{
    public abstract class Player
    {
        public abstract string Name { get; }
        public abstract string RoshamboValue { get; }

        public string GenerateRoshambo()
        {
            return RoshamboValue;
        }
    }
}
