using System;

namespace Assignment_04
{
    // static class -> no need to create an instance to call its methods
    public static class Maths
    {
        public static double Add(double a, double b)
        {
            return a + b;
        }

        public static double Subtract(double a, double b)
        {
            return a - b;
        }

        public static double Multiply(double a, double b)
        {
            return a * b;
        }

        public static double Divide(double a, double b)
        {
            if (b == 0)
                return 0;

            return a / b;
        }
    }
}
