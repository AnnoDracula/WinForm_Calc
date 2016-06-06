using System;

namespace MethodsLibrary
{
    public static class MathMethods
    {
        private static double Summ(double a, double b)
        {
            return (a + b);
        }

        private static double Diff(double a, double b)
        {
            return (a - b);
        }

        private static double Multiplication(double a, double b)
        {
            return (a * b);
        }

        private static double Division(double a, double b)
        {
            return (a * 1.0 / b);
        }

        public static double Calculate(double a, double b, int sign)
        {
            double result;
            switch (sign)
            {
                case 1:
                    result = Summ(a, b);
                    break;
                case 2:
                    result = Diff(a, b);
                    break;
                case 3:
                    result = Multiplication(a, b);
                    break;
                case 4:
                    result = Division(a, b);
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
            return result;
        }
    }
}
