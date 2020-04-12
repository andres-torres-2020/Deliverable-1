using System;

namespace Deliverable1
{
    class Program
    {
        /*
            A. TORRES
            
            DELIVERABLE # 1
        */
        static void Main(string[] args)
        {
            bool isValid = false;

            string vacationType;
            int groupSize = 0;

            // get vacation type
            do {
            Console.Write("What kind of trip would you like to go on, musical, tropical, or adventurous? ");
                vacationType = Console.ReadLine().ToLower();
                isValid = (vacationType == "musical" || vacationType == "tropical" || vacationType == "adventurous");
                if (isValid == false)
                {
                    Console.WriteLine("   *** Please enter one of the trip choices.");
                }
            } while (isValid == false);

            // get group size
            isValid = false;
            do {
                Console.Write("How many are in your group? ");
                string input = Console.ReadLine().Trim();
                isValid = int.TryParse(input, out groupSize);
                if (isValid == false || groupSize <= 0)
                {
                    Console.WriteLine("   *** Please enter an integer for your group size.");
                }
            } while (isValid == false || groupSize <= 0);


            // destination determined by vacation type entered
            string destination;
            string vacationPronoun = "a";
            if (vacationType == "musical") {
                destination = "New Orleans";
            }
            else if (vacationType == "tropical") {
                destination = "a Beach Vacation in Mexico";
            }
            else { // vacationType == "adventurous"
                destination = "Whitewater Rafting the Grand Canyon";
                vacationPronoun = "an";
            }

            // travel determined by group size entered
            string travel = "";
            if (groupSize >= 1 && groupSize <= 2)
            {
                travel = "First Class flight";
            }
            else if (groupSize >= 3 && groupSize <= 5)
            {
                travel = "Helicopter";
            }
            else if (groupSize >= 6)
            {
                travel = "Charter Flight";
            }

            // construct result message
            string result =
                "Since you’re a group of " + groupSize
                + " going on " + vacationPronoun + " " + vacationType
                + " vacation, you should take a " + travel
                + " to " + destination + "."
                ;
            Console.WriteLine(result);
        }
    }
}
