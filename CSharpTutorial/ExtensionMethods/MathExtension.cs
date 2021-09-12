
namespace MathExtension
{
    public static class MathExtension
    {
        public static double ToSquare(this double input)
        {
            return input * input;
        }

        public static double ToCube(this double input)
        {
            return input * input * input;
        }

        public static double ToFactorial(this double input)
        {
            return ((input == 0) || (input == 1)) ? 1 : input * (input - 1).ToFactorial();
        }

        public static double MultiplyBy(this double input, double multiplyBy)
        {
            return input * multiplyBy;
        }

        public static bool IsNegative(this double input)
        {
            return input < 0 ? true : false;
        }

        public static bool IsPositive(this double input)
        {
            return input > 0 ? true:false;
        }
 
    }
}
