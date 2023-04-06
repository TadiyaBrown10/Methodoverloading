using System;

namespace MethodOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static decimal Add(decimal x, decimal y)
        {
            return x + y;

        }


        public static string Add(int c, int d, bool checkit)
        {
            var sum = c + d;

            if(checkit == true && sum > 1)
            {
                return $"{sum} dollars";
            }

            else if(checkit == true && sum == 1)
            {
                return $"{sum} dollar";
            }
            else if (checkit == true && sum < 1)
            {
                return $"{sum} dollars";

            }
            else
            {
                return sum.ToString();
            }
        }
    }
}

