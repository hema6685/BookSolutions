using System;

namespace CalculateAge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your date of birth: ");
            DateTime.TryParse(Console.ReadLine() ,out DateTime dob);
            //dob = new DateTime(2012, 07, 05);
            DateTime today = DateTime.Today;

            /*TimeSpan age = today.Subtract(dob); // now- dob
            double age1 = age.TotalDays / 365.25;
            int age2 = (int)age1;*/
            int age = today.Year - dob.Year;

            if (dob.Month >= today.Month & dob.Day > today.Day )
                age--;
            
            Console.WriteLine($"age from {dob} to today {today} is: {age}");
        }
    }
}
