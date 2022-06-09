using System;
using SwordDamageEnhanced;

namespace WeaponDamage
    {
    class Program
    {
        static Random random = new Random();
        static void Main(string[] args)
        { /*
        Update the Main method to use a switch statement to let the user choose the type of weapon.
    Start by copying the Main and RollDice methods from the exercise solution at the end of the last
    chapter.
    1. Create an instance of ArrowDamage at the top of the method, just after you create the SwordDamage instance.
    2. Modify the RollDice method to take an int parameter called numberOfRolls so you can call RollDice(3) to roll 3d6
    (so it calls random.Next(1, 7) three times and adds the results), or RollDice(1) to roll 1d6.
    3. Add the two lines of code exactly like they appear above that write the sword or arrow prompt to the console, read
    the input using Console.ReadKey, use Char.ToUpper to convert the key to uppercase, and store it in weaponKey.
    4. Add the switch statement. It will be exactly the same as the switch statement above, except you’ll replace
    each of the /* comments *//* with code that calculates damage and writes a line of output to the console.

             */

            static int RollDice(int numberOfRolls)
            { 
                int total = 0;
                for (int i = 0; i < numberOfRolls; i++)
                    total += random.Next(1, 7);
                return total;                
            }
            SwordDamage swordDamage = new SwordDamage(RollDice(3));
            ArrowDamage arrowDamage = new ArrowDamage(RollDice(1));
            while (true)
            {
                Console.Write("0 for no magic/flaming, 1 for magic, 2 for flaming, " +
                "3 for both, anything else to quit: ");
                char key = Console.ReadKey().KeyChar;
                if (key != '0' && key != '1' && key != '2' && key != '3') return;

                Console.Write("\nS for sword, A for arrow, anything else to quit: ");
                char weaponKey = Char.ToUpper(Console.ReadKey().KeyChar);
                switch (weaponKey)
                {
                    case 'S':
                        swordDamage.Roll = RollDice(3);
                        swordDamage.Magic = (key == '1' || key == '3');  //bool
                        swordDamage.Flaming = (key == '2' || key == '3'); //bool
                        Console.WriteLine("\nRolled " + swordDamage.Roll + " for " + swordDamage.Damage + " HP\n");
                        break;
                        
                    case 'A':
                        arrowDamage.Roll = RollDice(1);
                        arrowDamage.Magic = (key == '1' || key == '3');
                        arrowDamage.Flaming = (key == '2' || key == '3');
                        Console.WriteLine(
                        $"\nRolled {arrowDamage.Roll} for {arrowDamage.Damage} HP\n");
                        break;

                    default:
                        return;
                }
            }
        }
    }
}
