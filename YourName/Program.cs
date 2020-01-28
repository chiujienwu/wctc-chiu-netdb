using System;

namespace YourName  // think of namespace container for your organization often using specific libraries and environment
{
    class MainClass  // object container with properties and functions
    {
        public static void Main(string[] args)  //console application expects a main method as an entry point
        {
            // display a literal value
            Console.WriteLine("What is your name?");
            // input a value and assign it to a string variable
            string name = Console.ReadLine();
            // display the string variable
            Console.WriteLine("Hello, " + name);
            Console.WriteLine("Hello, {0}", name);
        }
    }
}
