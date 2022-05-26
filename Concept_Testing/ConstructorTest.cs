using System;
using System.Collections.Generic;
using System.Text;

namespace Concept_Testing
{
    class ConstructorTest
    {
        public int i = 1;
        
        public ConstructorTest(int i)
        {
            this.i = i;
            Console.WriteLine($"i is {this.i}");
        }
    }
}
