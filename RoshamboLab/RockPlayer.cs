using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Create a subclass for RockPlayer that always throws a rock
namespace RoshamboLab
{
    public class RockPlayer : Player
    {
        public override string Name { get; }

        public RockPlayer() { }

        public override Roshambo GenerateRoshambo()
        {
            return Roshambo.rock;
        }
    }
}

