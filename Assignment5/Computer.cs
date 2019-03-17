using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    class Computer
    {
        //Create a class called Computer.This class will have a constructor in it that will take and int and save it in a private member variable.
        private int _value;

        public Computer(int obj)
        {
            _value = obj;
        }

    //The Computer class will contain a public delegate called ComputeAnswer that will take an int argument and return a double.
    //public delegate ComputerAnswer
    //Takes int returns Double


    //The Computer class will also contain a public method called GetAnswer() which will take a single argument 
    //which is the delegate and return void. This method will call the delegate and display the computed answer when the delegate returns.

    //public void GetAnswer(ComputerAnswer a)
    //{

    //}

}
}
