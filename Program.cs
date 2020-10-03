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

                if (lengthLineOne > lengthLineTwo)
                {
                    Console.WriteLine("The First Line is Greater in Length.");
                }
                else
                {
                    Console.WriteLine("The Second line is Greater in length.");
                }
            }
            else
            {
                Console.WriteLine("Both Lines are Equal");
            }

            //Length Line Comparison - Method 2 , Using Inbuilt function

            int choice = Math.Sign(lengthLineTwo.CompareTo(lengthLineOne));
            if(choice==1)
            {
                Console.WriteLine("The Line Two is greater");
            }
            else if(choice ==-1)
            {
                Console.WriteLine("The Line One is greater");
            }
            else
            {
                Console.WriteLine("The Lines are Equal");
            }
        }
    }
}
