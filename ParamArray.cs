using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    internal class ParamArray
    {
        public static void Main()
        {
            int total = sum(3, 7, 2, 9, 3, 6, 1, 8);
            Console.WriteLine(total);
        
            Console.ReadLine();
        }
        public static int sum(params int[] numbers)
        {
            int sum = 0;
            foreach (int i in numbers) 
            {
                sum += i;
             
            }
            return sum;
        }
      

       
    }
}
