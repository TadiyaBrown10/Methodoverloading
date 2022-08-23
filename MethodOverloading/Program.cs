using System;

namespace MethodOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        public static int Add2(int a, int b)
        {
            return a + b;
        }

        public static int Add3(int x, int y)
        {
            return x + y;

        }

        public static int add(int c, int d)
        {
            return c + d;
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

