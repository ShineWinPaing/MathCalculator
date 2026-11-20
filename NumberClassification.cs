namespace MathCalculator;

public static class NumberClassification
{
    ///<summary>
    /// Extracts even numbers from an array of integers.
    ///</summary>
    /// <param name="numbers">The array of integers to filter.</param>
    /// <returns>An array containing only the even numbers.</returns>
    public static Array ExtractEven(int[] numbers)
    {
        if (numbers == null || numbers.Length == 0)
        {
            return new int[0];
        }
        var evenNumbers = numbers.Where(n => n % 2 == 0).ToArray();
        return evenNumbers;
    }

    /// <summary>
    /// Extracts odd numbers from an array of integers.
    /// </summary>
    /// <param name="numbers">The array of integers to filter.</param>
    /// <returns>An array containing only the odd numbers.</returns>
    public static Array ExtractOdd(int[] numbers)
    {
        if (numbers == null || numbers.Length == 0)
        {
            return new int[0];
        }
        var oddNumbers = numbers.Where(n => n % 2 != 0).ToArray();
        return oddNumbers;
    }

    /// <summary>
    /// Extracts prime numbers from an array of integers.
    /// </summary>
    /// <param name="numbers"></param>
    /// <returns></returns>
    public static Array ExtractPrime(int[] numbers)
    {
        if (numbers == null || numbers.Length == 0)
        {
            return new int[0];
        }
        var primeNumbers = numbers.Where(NumberType.IsPrime).ToArray();
        return primeNumbers;
    }

    /// <summary>
    /// Provides utility methods for classifying numbers.
    /// </summary>
    private static class NumberType
    {
        public static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;
            var boundary = (int)Math.Sqrt(number);
            for (int i = 3; i <= boundary; i += 2)
            {
                if (number % i == 0) return false;
            }
            return true;
        }
    }
}