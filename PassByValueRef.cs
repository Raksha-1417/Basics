using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    internal class PassByValueRef
    {
        public static void Main()
        {
            int a = 10;
            int b = 20;
            Console.WriteLine($"Before swap : a:{a},b:{b}");
            swap(a, b);
            Console.WriteLine($"After SWap : a:{a},b:{b}");


        }
        public static void swap(int num1, int num2)
        {
            Console.WriteLine($"Before Swap:num1:{num1},num2:{num2}");
            int temp;
            temp = num1;
            num1 = num2;
            num2 = temp;
            Console.WriteLine($"After Swap:num1: {num1},num2:{num2}");
        }
    }

}
