using System;

namespace square_number
{
    class program
    {

        public static void Main(string[] args)
        {

            Console.Write("Enter the Number : ");
            int n = int.Parse(Console.ReadLine());
            int n1;
            for (int i = 0; i < n; i++)
            {
                if(i<=n)
                {
                    n1=i*i;
                    Console.WriteLine(n1);
                }
            }

        }
    }
}