using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Y9_DEC_TO_BIN_SKELETON
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //STARTER: Practice using breakpoints and the watch window (F8 to single-step, F11 to start in single step mode)
            int myInt = 0; //just for testing single stepping
            string myString = "12"; //watch me being cast from string to int

            //TASK 1:
            int myStringAsInt = Convert.ToInt32(myString); //watch me cast from string to int

          
            //TASK 2:

            int insertmyString = Convert.ToInt32(myString.Insert(0,"Your number is "));

            //MAIN:  NUMBER CONVERSION PROGRAM
            Console.WriteLine("Enter your number");
            Console.WriteLine(numberConversion(Convert.ToInt32(Console.ReadLine()), 2));
        }

        //static void means the function will not return a value so it does not need a data type 
        //...this function DOES return a value so the method must have a data type
        static string numberConversion(int number, int numberbase)
        {
            string binaryArray = { };
            return Convert.ToString(number % numberbase);
        }
    }
}
