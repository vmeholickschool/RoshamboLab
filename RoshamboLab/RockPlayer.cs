using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoshamboLab
{
    internal class RockPlayer : Player
    {
        public override string Name { get; } = "Always throws Rock";

        public override string RoshamboValue { get; }

        public RockPlayer(string roshamboValue)
        {
            RoshamboValue = roshamboValue;
        }
    }
}

