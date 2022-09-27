using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    internal class OutKeyword
    {
        public static void Main()
        {
            int i;
            int j;
            add(out i, out j);
            Console.WriteLine(i+" "+ j);

        }
        public static void add(out int a, out int b)
        {
            a = 10;
            b = 20;
            a += a;
            b += b;




        }
    }
}
