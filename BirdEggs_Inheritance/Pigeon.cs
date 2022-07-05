using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
  Create the Pigeon class that extends Bird. Override the LayEggs method and have it lay eggs with the color
“white” and a size between 1 and 3 centimeters.
 */
namespace BirdEggs_Inheritance
{
    class Pigeon : Bird
    {
        public override Egg[] LayEggs(int numberOfEggs)
        {
            Egg[] eggs = new Egg[numberOfEggs];
            for (int i = 0; i < numberOfEggs; i++)
            {
                eggs[i] = new Egg(Bird.Randomizer.NextDouble() * 2 + 1, "white");
            }
            return eggs;
        }
    }
}
