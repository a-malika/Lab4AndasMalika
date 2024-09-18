using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//2 задание
//Open-Closed Principle
namespace Laboratory4
{
    public interface DiscountCalculator
    {
        public double CalculateDiscount(double amount);
    }
    public class RegularDiscountCalculator : DiscountCalculator
    {
        public double CalculateDiscount(double amount)
        {
            return amount;
        }
    }
    public class SilverDiscountCalculator : DiscountCalculator
    {
        public double CalculateDiscount(double amount)
        {
            return amount * 0.9;
        }
    }
    public class GoldDiscountCalculator : DiscountCalculator
    {
        public double CalculateDiscount(double amount)
        {
            return amount * 0.8;
        }
    }

}
