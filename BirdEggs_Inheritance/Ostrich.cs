using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Create the Ostrich class that also extends Bird. Override the LayEggs method and have it lay eggs with the color
“speckled” and a size between 12 and 13 centimeters.
 */
namespace BirdEggs_Inheritance
{
    class Ostrich : Bird
    {
        public override Egg[] LayEggs(int numberOfEggs)
        {
            Egg[] eggs = new Egg[numberOfEggs];
            for(int i=0; i<numberOfEggs; i++)
            {
                eggs[i] = new Egg(Bird.Randomizer.NextDouble() + 12 ,"speckled");
            }
            return eggs;


        }
        
    }
}
