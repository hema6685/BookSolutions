using System;

namespace Concept_Testing
{
    class Program
    {
        static void Main(string[] args)
        {
            new ConstructorTest(5);
            
            NoNew o = NoNew.CreateInstance();

        }
        class NoNew
        {
            private NoNew() { Console.WriteLine("I'm alive!"); }
            public static NoNew CreateInstance() { return new NoNew(); }
        }
    }
}
