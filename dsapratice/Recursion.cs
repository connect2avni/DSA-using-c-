/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsapratice
{
    public class Program
    {
        static void Main(string[] args)
        {
            Recursion r= new Recursion();
           *//* r.calculateiterative(4);
            Console.ReadLine();*/

            /*r.calculateiterative(5);
            Console.ReadLine();
*//*
            r.calculate(3);
            Console.ReadLine();


        }
    }

    
    public class Recursion
    {

        public void calculate(int n)
        {
            if (n > 0)
            {
                calculate(n - 1);
                int k = n * n;
                Console.WriteLine(k);
                calculate(n - 1);
            }
        }
        public void calculateiterative(int n)
        {
            while(n>0)
            {
                int k = n * n;
                Console.WriteLine(k);
                n = n - 1;
            }
        }
        public void calculateRecursive(int n)
        {
            if (n > 0)
            {
                int k = n * n;
                Console.WriteLine(k);
                calculateRecursive(n-1);
            }
        }
    }
}
*/