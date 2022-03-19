using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace chapter03
{
    internal class Exercises
    {
        /*
         * 6. Write a program that prints on the console the perimeter and the area
         * of a rectangle by given side and height entered by the user.
         */
        public static void Exercise6(long length, long width)
        {
            long perimeter = (length + width) * 2;
            long area = length * width;
            Console.WriteLine("Area = " + area);
            Console.WriteLine("Perimeter = " + perimeter);
        }

        /*
         * 7. The gravitational field of the Moon is approximately 17% of that on the 
         * Earth. Write a program that calculates the weight of a man on the
         * moon by a given weight on the Earth.
         */
        public static void Exercise7(long weight)
        {
            Console.WriteLine("Weight on moon = " + weight * 0.17);
        }

        /*
         * 8. Write an expression that checks for a given point {x, y} if it is within
         * the circle K({0, 0}, R=5). Explanation: the point {0, 0} is the center of
         * the circle and 5 is the radius.
         */
        public static void Exercise8(Point point)
        {
            var x = point.X; var y = point.Y;
            bool isEx8Valid = (x * x) + (y * y) == 5 * 5;
            Console.WriteLine("This point is " + (isEx8Valid ? "": "not") + "in circle");
        }

        /*
         * 9. Write an expression that checks for given point {x, y} if it is within the 
         * circle K({0, 0}, R=5) and out of the rectangle [{-1, 1}, {5, 5}].
         * Clarification: for the rectangle the lower left and the upper right corners 
         * are given.
         */
        public static void Exercise9(Point point)
        {
            var x = point.X; var y = point.Y;
            bool isInCircle = (x * x) + (y * y) == 5 * 5;
            bool isInRect = (x > -1 && x < 5) && (y < 1 && y > 5);
            bool isEx9Valid = isInCircle && isInRect;
            Console.WriteLine("This point is " + (isEx9Valid ? "" : "not") + "in circle and rectangle");
        }

        /*
         * 10. Write a program that takes as input a four-digit number in format abcd
         * (e.g. 2011) and performs the following actions:
         * - Calculates the sum of the digits (in our example 2+0+1+1 = 4).
         * - Prints on the console the number in reversed order: dcba (in our example 1102).
         * - Puts the last digit in the first position: dabc (in our example 1201).
         * - Exchanges the second and the third digits: acbd (in our example 2101) 
         */
        public static void Exercise10(string num)
        {
            var sumDigits = 0;
            var reverseDigits = "";
            foreach(char digit in num.ToString())
            {
                sumDigits += int.Parse(digit.ToString()); // step 1
                reverseDigits = digit.ToString() + reverseDigits; // step 2
            }

            char[] swapFirstLast, swapSecThird;
            {
                // step 3
                swapFirstLast = num.ToCharArray();
                var tmp = swapFirstLast[0];
                swapFirstLast[0] = swapFirstLast[3];
                swapFirstLast[3] = tmp;
            }
            {
                // step 4
                swapSecThird = num.ToCharArray();
                var tmp = swapSecThird[1];
                swapSecThird[1] = swapSecThird[2];
                swapSecThird[2] = tmp;
            }
        }

        /*
         * 11. We are given a number n and a position p. Write a sequence of 
         * operations that prints the value of the bit on the position p in the
         * number (0 or 1). Example: n=35, p=5 -> 1. Another example: n=35,
         * p=6 -> 0.
         */
        public static void Exercise11(int n, int p)
        {
            int i = 1;
            int mask = i << p;
            Console.WriteLine((n & mask) != 0 ? 1 : 0);
        }

        /*
         * 12. Write a Boolean expression that checks if the bit on position p in the
         * integer v has the value 1. Example v=5, p=1 -> false.
         */
        public static void Exercise12(int v, int p)
        {
            int mask = 1 << p;
            bool isEx12Valid = mask == 0;
            Console.WriteLine(isEx12Valid);
        }

        /*
         * 13. We are given the number n, the value v (v = 0 or 1) and the position p.
         * write a sequence of operations that changes the value of n, so the bit on
         * the position p has the value of v. Example: n=35, p=5, v=0 -> n=3.
         * Another example: n=35, p=2, v=1 -> n=39.
         */
        public static void Exercise12(int n, int p, int v)
        {

        }

        /*
         * 14. Write a program that checks if a given number n (1 < n < 100) is a
         * prime number (i.e. it is divisible without remainder only to itself and 1)
         */
        public static void Exercise13(int num)
        {
            bool isPrime = true;
            for(int i = 2; i < num; i++)
            {
                if (num % i == 0) isPrime = false;
                break;
            }
            Console.WriteLine(num + "is " + (isPrime ? "" : "not") + " a prime number");
        }


    }
}
