namespace MathCalculator
{
    public static class BasicCalculator
    {
        ///<summary>
        /// Adds two numbers.
        ///</summary>
        /// <param name="a">The first number.</param>
        /// <param name="b">The second number.</param>
        /// <returns>The sum of the two numbers.</returns>
        public static double Add(double a, double b)
        {
            return a + b;
        }

        ///<summary>
        /// Subtracts the second number from the first.
        ///</summary>
        /// <param name="a">The first number.</param>
        /// <param name="b">The second number.</param>
        /// <returns>The difference of the two numbers.</returns>
        public static double Subtract(double a, double b)
        {
            return a - b;
        }

        ///<summary>
        /// Multiplies two numbers.
        ///</summary>
        /// <param name="a">The first number.</param>
        /// <param name="b">The second number.</param>
        /// <returns>The product of the two numbers.</returns>
        public static double Multiply(double a, double b)
        {
            return a * b;
        }

        /// <summary>
        /// Quotient of first number divided by second number.
        /// </summary>
        /// <param name="a">The first number(dividend).</param>
        /// <param name="b">The second number(divisor).</param>
        /// <returns>The quotient of the two numbers.</returns>
        /// <exception cref="ArgumentException"></exception>
        public static double Quotient(double a, double b)
        {
            if (b==0)
            {
                throw new ArgumentException("The second number cannot be zero.");
            }
            return a / b;
        }

        /// <summary>
        /// Remaining of first number divided by second number.
        /// </summary>
        /// <param name="a">The first number(dividend).</param>
        /// <param name="b">The second number(divisor).</param>
        /// <returns>The remainder of the two numbers.</returns>
        /// <exception cref="ArgumentException"></exception>
        public static double Remainder(double a, double b)
        {
            if (b == 0)
            {
                throw new ArgumentException("The second number cannot be zero.");
            }
            return a % b;
        }
    }
}

