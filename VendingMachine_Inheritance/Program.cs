using System;

namespace VendingMachine_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            VendingMachine vendingMachine = new AnimalFeedVendingMachine();
            Console.WriteLine(vendingMachine.Dispense(2.00M));

            //vendingMachine.CheckAmount(1F);


        }
    }
}
