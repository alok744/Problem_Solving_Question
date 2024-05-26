using System;

namespace Leap_year
{
    class program
    {
      
        public static void Main(string[] args)
        {
           
            Console.Write("Enter the year : ");

            int n=int.Parse(Console.ReadLine());
            bool n1;
            bool n2;

            if (n % 4 == 0)
            {
                n1=true;
                Console.WriteLine(n1);
                Console.WriteLine("Leap Year");
            }
            else
            {
                n2 = false;
                Console.WriteLine(n2);
                Console.WriteLine("Not A Leap Year");
            }
        }
    }
}