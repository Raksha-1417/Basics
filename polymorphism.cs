using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
   
    internal class polymorphism
    {
        public static int num;
        public static void add()
        {
            num += 10;
            Console.WriteLine(num);
        }
        public static void add(int a)
        {
            a += a;
            Console.WriteLine(a);
        }
        public static void add(double a)
        {
            a += a;
            Console.WriteLine(a);
        }
        public static void GetDetails(int id, string name)
        {
            Console.WriteLine($"{id}:{name}");  

        }
        public static void GetDetails(string name, int id)
        {
            Console.WriteLine($"{name}:{id}");

        }
        public static void main()
        {
            add();
            add(10);
            add(12.34);
            GetDetails(10, "Riya");
            GetDetails("Riya",10);
        }
    }
}
