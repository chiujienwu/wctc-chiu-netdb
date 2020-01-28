using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson02
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] bogusArray = new string[]
            {
                "tom",
                "richard",
                "harry"
            };

/*          Console.WriteLine("The second name is " + bogusArray[1]);
            Console.WriteLine($"The scond name is : {bogusArray[1]}");  // new string interpolation
            Console.WriteLine("The second name is : {0}", bogusArray[1]);  // old string interpolation*/
            /*Resharper helps with code complete*/

            //bogusArray.Count() is a method that provides same value as bogusArray.Length

            for (int i = 0; i < bogusArray.Count(); i++)
            {
                Console.WriteLine($"The second name is : {bogusArray[i]}");
            }

            //implicit variables must be initialized because computer doesn't know what type to assign

            foreach (var name in bogusArray)
            {
                Console.WriteLine($"The second name is : {name}");
            }
        }
    }
}
