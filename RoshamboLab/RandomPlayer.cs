using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Create subclass RandomPlayer that picks and throws a value at random


namespace RoshamboLab
{
    public class RandomPlayer : Player
    {
        public override string Name { get; } = "Random";

        public RandomPlayer()
        {
            random = new Random();
        }

        public override Roshambo GenerateRoshambo()
        {
            Array values = Enum.GetValues(typeof(Roshambo));
            return (Roshambo)values.GetValue(random.Next(values.Length));
        }
    }
}