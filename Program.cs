using System;

namespace print_number
{
    class program
    {

        public static void Main(string[] args)
        {

            Console.Write("Enter the Number : ");
            int n=int.Parse(Console.ReadLine());

            for (int i = 1; i < n; i++)
            {
                Console.Write(i);
            }
            
        }
    }
}