namespace Practice3Part2.Task1
{
    public class MathHelper
    {
        public double Add(double a, double b)
        {
            return a + b;
        }

        public double Subtract(double a, double b)
        {
            return a - b;
        }

        public double Multiply(double a, double b)
        {
            return a * b;
        }

        public double Divide(double a, double b)
        {
            if (b == 0)
            {
                throw new System.ArgumentException("Division by zero is not allowed");
            }
            return a / b;
        }
    }
}
