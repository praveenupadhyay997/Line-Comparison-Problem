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

            double lengthLineOne=0,lengthLineTwo=0;
            for(int i=0;i<2;i++)
            {
                int lineNumber = (i == 0) ? 1 : 2;
                Console.WriteLine("Enter x and y co-ordinate of first Point of Line Number {0}: ",lineNumber);

                double absciccaOne = Convert.ToDouble(Console.ReadLine());
                double ordinateOne = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter x and y co-ordinate of second Point Line Number {0}: ", lineNumber);
                double absciccaTwo = Convert.ToDouble(Console.ReadLine());
                double ordinateTwo = Convert.ToDouble(Console.ReadLine());

                // Line Property object declaration to initialise the constructor
                LineProperties lineProperties = new LineProperties(absciccaOne, ordinateOne, absciccaTwo, ordinateTwo);
                if(i==0)
                {
                    lengthLineOne = lineProperties.lengthOfLine(absciccaOne, ordinateOne, absciccaTwo, ordinateTwo);
                }
                else
                {
                    lengthLineTwo = lineProperties.lengthOfLine(absciccaOne, ordinateOne, absciccaTwo, ordinateTwo);
                }
                
            }
            if(lengthLineOne!=lengthLineTwo)
            {
                Console.WriteLine("Both Lines are not Equal");
            }
            else
            {
                Console.WriteLine("Both Lines are Equal");
            }
        }
    }
}
