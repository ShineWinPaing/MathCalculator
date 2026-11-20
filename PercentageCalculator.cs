namespace MathCalculator;

public static class PercentageCalculator
{
    ///<summary>
    /// Calculates what percentage 'part' is of 'total'.
    ///</summary>
    /// <param name="part">The part to calculate the percentage of.</param>
    /// <param name="total">The total value.</param>
    /// <returns>The calculated percentage.</returns>
    public static double CalculatePercentage(double part, double total)
    {
        if (total == 0)
        {
            throw new ArgumentException("The total cannot be zero.");
        }
        return (part / total) * 100;
    }

    ///<summary>
    /// Calculates the discount amount based on the original price and discount percentage.
    ///</summary>
    /// <param name="Price">The original price.</param>
    /// <param name="discountPercent">The discount percentage.</param>
    /// <returns>The discount amount.</returns>
    public static double CalculateDiscount(double Price, double discountPercent)
    {
        if (Price < 0)
        {
            throw new ArgumentException(nameof(Price), "The original price cannot be negative.");
        }

        if (discountPercent < 0 || discountPercent > 100)
        {
            throw new ArgumentException(nameof(discountPercent), "Discount percentage must be between 0 and 100.");
        }

        return Price * (discountPercent / 100);
    }

    ///<summary>
    /// Applies a discount to the original price.
    ///</summary>
    /// <param name="Price">The original price.</param>
    /// <param name="discountPercent">The discount percentage.</param>
    /// <returns>The price after the discount is applied.</returns>
    public static double ApplyDiscount(double Price, double discountPercent)
    {
        if (Price < 0)
        {
            throw new ArgumentException(nameof(Price), "The original price cannot be negative.");
        }

        if (discountPercent < 0 || discountPercent > 100)
        {
            throw new ArgumentException(nameof(discountPercent), "Discount percentage must be between 0 and 100.");
        }
        return Price - CalculateDiscount(Price, discountPercent);
    }
}

