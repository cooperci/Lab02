using System;

namespace Lab02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Grand Circus Room Detail Generator!");


            Console.Write("Enter Length:: ");
            decimal length = decimal.Parse(Console.ReadLine());

            Console.Write("Enter Width: ");
            decimal width = decimal.Parse(Console.ReadLine());

            decimal area = length * width;
            Console.WriteLine("Area: {0}", area);

            decimal perimeter = 2 * (length + width);
            Console.WriteLine("Perimeter: {0}", perimeter);

            string response;

            Console.WriteLine("Would you like to continue (y/n)?");
             response = Console.ReadLine();
               if (response != "y" && response != "n")
              {
                 Console.WriteLine("OOPS! You need to enter 'y' or 'n'!");
                   response = "y";
               }
            {
                while (response == "y") ;

                Console.WriteLine("Goodbye!");
            }

        }
    }

}
   
 