using System;
using System.Collections.Generic;
using System.Linq;

namespace Concept_Testing
{
    class Program
    {
        static void Main(string[] args)
        {
            //constructor called without ref
            new ConstructorTest(5);

            // instance creation with private constructor
            NoNew o = NoNew.CreateInstance();

            int[] numbers = { 5, 10, 8, 3, 6, 12 };

            IEnumerable<int> q3 = numbers.Where(x => x > 3);
            int q4 = numbers.Where(x => x > 10).Count();          
            
            var squaredNumbers = numbers.Select(x => x * x).Where(x => x < 100);

            foreach (int i in squaredNumbers)
            {
                Console.WriteLine(i);
            }
            //Query syntax:
            IEnumerable<int> numQuery1 =
                from num in numbers
                //where num % 2 == 0
                orderby num
                select num;

            foreach (int i in numQuery1)
                Console.WriteLine(i);

            IEnumerable<int> q2 =
            from n in numbers where n == 5 select n;
            foreach (int i in q2)
                Console.WriteLine(i);



            string[] groupingQuery = { "carrots", "cabbage", "broccoli", "beans", "barley" };
            IEnumerable<IGrouping<char, string>> queryFoodGroups =
                from item in groupingQuery
                group item by item[0];

            foreach (string i in groupingQuery)
                Console.WriteLine(i);


            

        }
        class NoNew
        {
            private NoNew() { Console.WriteLine("I'm alive!"); }
            public static NoNew CreateInstance() { return new NoNew(); }
        }



    }
}
