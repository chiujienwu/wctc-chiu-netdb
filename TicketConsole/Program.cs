using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TicketConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            string file = "Tickets.csv";
            ConsoleKeyInfo choice;  //test test test

            do
            {
                // ask user a question
                Console.WriteLine("1) Read data from file.");
                Console.WriteLine("2) Create file from data.");
                Console.WriteLine("Enter any other key to exit.");
                choice = Console.ReadKey(true);

                if (choice.Key == ConsoleKey.D1)  /*This is for the 1 key*/
                {
                    if (File.Exists(file))
                    {
                        StreamReader ticketFile = new StreamReader(file);
                        string line = ticketFile.ReadLine();
                        string[] header = line.Split(',');  /*/reads the first line of file which contains table header*/

                        while (!ticketFile.EndOfStream)
                        {
                            line = ticketFile.ReadLine();
                            // converts string to array
                            string[] tickets = line.Split(',');
                            // display array data
                            foreach (string x in tickets)
                            {
                                Console.WriteLine($"Ticket: {x}");
                            }
                            
                        }
                    }
                }


            } while (choice.Key == ConsoleKey.D1 || choice.Key == ConsoleKey.D2);
        }
    }
}
