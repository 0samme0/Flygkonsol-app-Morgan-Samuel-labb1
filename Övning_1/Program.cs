using System.ComponentModel.Design;

namespace Övning_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nyDepartureHour = 10, nyDepartureMinute = 10;
            int sthlmDepartureHour = 14, sthlmDepartureMinute = 03;
            int flightHours = 7, flightMinutes = 25;
            int timeDifference = 6;
            int userchoice;
            while (true) 
            {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("            --|--");
            Console.WriteLine("- - - *---0--(_)--0---* - - -");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Welcome to fly time calculator");
            Console.WriteLine("What flight do you want to know more about? (Answer with number 1-3)");
            Console.WriteLine("1. Stockholm - New York ");
            Console.WriteLine("2. New york - Stockholm ");
            Console.WriteLine("3. Close program");
            Console.Write("Write your choice here! ");
            userchoice = Convert.ToInt32(Console.ReadLine());
             

            if (userchoice == 1 || userchoice == 2 || userchoice == 3) {
                break;
            }
        }



            if (userchoice == 1) {
                int arrivalhour = sthlmDepartureHour + flightHours - timeDifference;
                int arrivalMinute = sthlmDepartureMinute + flightMinutes;

                Console.WriteLine("\n");
                Console.WriteLine("*********************************");
                Console.WriteLine("Departur time from Stockholm " + sthlmDepartureHour.ToString() + ":" + sthlmDepartureMinute.ToString("00"));
                Console.WriteLine("Arrival to New York " + arrivalhour.ToString() + ":" + arrivalMinute.ToString("00"));
                Console.WriteLine("*********************************");
            }
            else if (userchoice == 2) {
                int arrivalhour = nyDepartureHour + flightHours + timeDifference;
                int arrivalMinute = nyDepartureMinute + flightMinutes;

                Console.WriteLine("\n");
                Console.WriteLine("*********************************");
                Console.WriteLine("Departur time from New York " + nyDepartureHour.ToString() + ":" + nyDepartureMinute.ToString("00"));
                Console.WriteLine("Arrival to Stockholm " + arrivalhour.ToString() + ":" + arrivalMinute.ToString("00"));
                Console.WriteLine("*********************************");
            }
            else if (userchoice == 3) {
            {
                    Environment.Exit(0);
            }

            }
            Console.WriteLine("\nThe program is now going to shut down!");
        }
    }
}
