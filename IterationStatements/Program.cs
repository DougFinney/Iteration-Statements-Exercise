using System.Security.Cryptography.X509Certificates;

namespace IterationStatements
{
    public class Program
    {
        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000

        public static void Print1000s()
        {
            for (var i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }
        }
        //Write a method that will print to the console numbers 3 through 999 by 3 each time

        public static void PrintThrees()
        {
            for (var i = 3; i <= 999; i += 3)
            {
                Console.WriteLine(i);
            }
        }
        //Write a method to accept two integers as parameterss and check whether they are equal or not

        public static string TwoIntEqual(int num1, int num2)
        {
            //if (num1 == num2)
            //{
            //    Console.WriteLine("Those numbers are equal");
            //}
            //else
            //{
            //    Console.WriteLine("Those numbers are not equal");
            //}

            return (num1 == num2) ? "Those numbers are equal" : "Those numbers are not equal";
        }
        //Write a method to check whether a given number is even or odd

        public static void OddOrEven(int number)
        {
            if (number % 2 == 0)
            {
                Console.WriteLine($"{number} is even");
            }
            else
            {
                Console.WriteLine($"{number} is odd");
            }


        }

        //Write a method to check whether a given number is positive or negative

        public static void PositiveOrNegative(int num)
        { 
            if(num > 0)
            {
                Console.WriteLine($"{num} is Positive");
            }
            else if (num < 0)
            { 
                Console.WriteLine($"{num}) is Negative");
            }
            else
            {
                Console.WriteLine($"{num} is neither positive or negative");
            }
        }
        //Write a method to read the age of a candidate and determine whether they can vote.

        public static void AgeCheck()
        {
            bool userAge;
            int result;

            do
            {
                Console.WriteLine("User, what is your age");

                userAge = int.TryParse(Console.ReadLine(), out result);
            } while (!userAge);

            if (result < 18)
            {
                Console.WriteLine("You are not eligible at this time.");
            }
            else
            {
                Console.WriteLine("You are now eligible to vote");
            }
        }    
            
            //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()

        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10

        public static void InRange()
        {
            bool userResponse;
            int result;

            do
            {
                Console.WriteLine("Enter an integer.");

                userResponse = int.TryParse(Console.ReadLine(), out result);

            } while (!userResponse);

            //if (result >= -10 && result <= 10)
            //{
            //    Console.WriteLine($"{result} is between 10 & -10");
            //}
            //else
            //{
            //    Console.WriteLine($"{result} is not between 10 & -10");
            //}  

            Console.WriteLine((result >= -10 && result <= 10) ? $"{result} is between 10 & -10" : $"{result} is not between 10 & -10");
            

        }
        
        //Write a method to display the multiplication table(from 1 to 12) of a given integer

        public static void MultTable()
        {
            bool cont;
            int userInput;

            do
            {
                Console.WriteLine("Enter an Integer");

                cont = int.TryParse(Console.ReadLine(), out userInput);

            } while (!cont);
            
            for(var x = 1; x <= 12; x++)
            {
                Console.WriteLine($"{x} x {userInput} = {x * userInput}");
            }

        }

    

        

        //Call the methods to test them in the Main method below
        static void Main(string[] args)
        {
          //Print1000s();
          //PrintThrees();
          //Console.WriteLine(TwoIntEqual(2, 4));
          //Console.WriteLine(TwoIntEqual(3, 3));
          //OddOrEven(10);
          //OddOrEven(15);

          //PositiveOrNegative(2);
          //PositiveOrNegative(-100);
          //PositiveOrNegative(0);

          //AgeCheck();

          //InRange();

        MultTable();
        }
    }
}
