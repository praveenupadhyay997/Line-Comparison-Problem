using System;

namespace LineComparisonProblem
{
    class Program
    {

        /// <summary>Defines the entry point of the application.</summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            
            Console.WriteLine("==============================================");
            Console.WriteLine("Welcome to Line Comparison Computation Program");
            Console.WriteLine("==============================================");
            
            Console.WriteLine("Enter x and y co-ordinate of first Point : ");
            
            double absciccaOne = Convert.ToDouble(Console.ReadLine());
            double ordinateOne = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter x and y co-ordinate of second Point : ");
            double absciccaTwo = Convert.ToDouble(Console.ReadLine());
            double ordinateTwo = Convert.ToDouble(Console.ReadLine());

            // Line Property object declaration to initialise the constructor
            LineProperties lineProperties = new LineProperties(absciccaOne, ordinateOne, absciccaTwo, ordinateTwo);

            Console.WriteLine(lineProperties.lengthOfLine(absciccaOne, ordinateOne, absciccaTwo, ordinateTwo));


        }
    }
}
