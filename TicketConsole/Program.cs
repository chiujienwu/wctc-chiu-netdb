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

            // ticketID should switch to more dynamic assignment - see other notes below
            int ticketID;
            // maxID to track the last ticketID value to avoid duplication
            int maxID = 0;

            string ticketSummary;
            string submittedBy;
            string assginedTo;
            string watching;

            /* this assumes the existance of a file but does not automatically check for it
            instead from the main menu, it prompts user */
            string file = "Tickets.csv";

            // using keyboard press for menu selection
            ConsoleKeyInfo choice;

            do
            {
                // ask user a question
                Console.WriteLine("1) Read data from file.");
                Console.WriteLine("2) Create file from data.");
                Console.WriteLine("Enter any other key to exit.");
                choice = Console.ReadKey(true);

                // This is for the 1 key
                if (choice.Key == ConsoleKey.D1)
                {
                    if (File.Exists(file))
                    {
                        StreamReader ticketFile = new StreamReader(file);

                        while (!ticketFile.EndOfStream)
                        {
                            // reads the first line of the file
                            string line = ticketFile.ReadLine();
                            // takes first line and split into array elements using specified delimeter
                            string[] ticket = line.Split(',');

                            // display array data to console
                            Console.WriteLine("TicketID: {0}, Summary: {1}, Summary: {2}, Summary: {3}, Summary: {4}, Summary: {5}, Summary: {6},",
                                ticket[0], ticket[1], ticket[2], ticket[3], ticket[4], ticket[5], ticket[6]);

                            int readID = Convert.ToInt16(ticket[0]);

                            if (readID > maxID) { maxID = readID; }
                        }
                    }
                }
                // This is for the 2 key
                else if (choice.Key == ConsoleKey.D2)

                {
                    /* We are appending additional records on the fly to the file
                    therefore, no need for an array to hold additional ticket records in memory before
                    writing to file */

                    string resp;  // to capture user responses

                    do
                    {
                        // ask user if they wish to enter a new ticket
                        Console.WriteLine("Enter a ticket (Y/N)?");
                        // capture user response
                        resp = Console.ReadLine().ToUpper();
                        // if the response is anything other than "Y", stop asking
                        if (resp != "Y") { break; }

                        // assign a ticketID
                        ticketID = maxID + 2;
                        Console.WriteLine($"Creating a new ticket under Ticket ID : {ticketID}");

                        // prompt for ticket summary
                        Console.WriteLine("Enter ticket summary: ");
                        // save the ticket summary to variable
                        ticketSummary = Console.ReadLine();

                        // prompt for ticket status
                        Console.WriteLine("Enter ticket status: ");
                        // save the ticket status to variable
                        string ticketStatus = Console.ReadLine();

                        // prompt for ticket priority
                        Console.WriteLine("Enter ticket priority: ");
                        // save the ticket status to variable
                        string ticketPriority = Console.ReadLine();

                        // prompt for submittedBy
                        Console.WriteLine("Enter ticket submitter's full name: ");
                        // save the ticket status to variable
                        submittedBy = Console.ReadLine();

                        // prompt for assginedTo
                        Console.WriteLine("Enter full name ticket is to be assigned: ");
                        // save the ticket status to variable
                        assginedTo = Console.ReadLine();

                        // prompt for watching
                        Console.WriteLine("Enter full name of person watching ticket: ");
                        // save the ticket status to variable
                        watching = Console.ReadLine();

                        /*TicketID, Summary, Status, Priority, Submitter, Assigned, Watching
                         1,This is a bug ticket,Open,High,Drew Kjell, Jane Doe,Drew Kjell| John Smith | Bill Jones*/

                        StreamWriter sw = new StreamWriter(file, append: true);

                        sw.WriteLine("{0},{1},{2},{3},{4},{5},{6}",
                            ticketID, ticketSummary, ticketStatus, ticketPriority, submittedBy, assginedTo, watching);

                        sw.Close();

                    } while (resp != "N"); // do while loop for option 2 to continue adding records
                } // end else if
            } while (choice.Key == ConsoleKey.D1 || choice.Key == ConsoleKey.D2);
        } // end Main
    } // end class program
} // end namespace TicketConsole

