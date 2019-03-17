using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    class TestClass
    {

        //Create a class called TestClass that contains the Main() method.First, prompt the user for a number and be sure that the data they supply is valid.
        //Then, create a Computer object and supply it with the user’s number.Next, create two objects, one of type FactorialNumber and one of type SquareNumber.
        //Create two delegates, one for each of the ComputeValue methods, and then call the GetAnswer() method in the Computer class to perform the calculations.
        static void Main(string[] args)
        {
            //set value to min in value, for input validation
            int UserInt = int.MinValue;

            do
            {
                Console.WriteLine("Please enter a number: ");
                var UserInput = Console.ReadLine();
                try { UserInt = Convert.ToInt32(UserInput); }
                catch (FormatException e)
                {
                    Console.WriteLine("Input value does not appear to be a number, please try again.");
                }
                catch (OverflowException e)
                {
                    Console.WriteLine("The number cannot fit in an Int32, please try again.");
                }

                Console.WriteLine(UserInt);
            }
            //loop while input is not greater then the defaul min int value
            while (!(UserInt > int.MinValue));

            var value = new Computer(UserInt);



        }

    }
}
