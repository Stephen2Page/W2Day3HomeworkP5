using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W2Day3HomeworkP5
{
    class Program
    {
        //Create a method named "Double" to calculate and return an integer number doubled. 
        //For example. Double(7) should return 14. 
      

        static void Main(string[] args)
        {
            Console.WriteLine("Enter and interger");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(Double(number));
        }
        static int Double(int number)
        {
            int result = number * 2;
            return result;
        }
    }
}
