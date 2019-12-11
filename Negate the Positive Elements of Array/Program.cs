using System;
using System.Collections.Generic;
using System.Text;

namespace Negate_the_Positive_Elements_of_Array////This C# program, we are reading the value of 5 elements value using for loop and assign the value to ‘a[]’ array variable.///
{
    class Program
    {
        static void Main(string[] args)////If condition statement is used to check the value of ‘a[]’ variable is greater than 0. If the condition is true, then execute the statement. Assign the value of ‘a[]’ variable to the minus symbol of a[] variable. Hence using foreach loop print negate of positive elements of an array.//
        {
            int[] a = new int[10];
            Console.WriteLine("Enter 5 Elements : ");
            for (int i = 0; i < 5; i++)
            {
                a[i] = Convert.ToInt16(Console.ReadLine());
                if (a[i] > 0)
                    a[i] = -a[i];
            }
            Console.WriteLine("Elements:");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(a[i]);
            }
            Console.ReadLine();
        }
    }
}
///Output: {2,3,4,5,6}
///{-2,-3,-4,-5,-6}
