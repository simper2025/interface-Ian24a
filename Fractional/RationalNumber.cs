using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fractional
{
    public class RationalNumber : IEquatable<RationalNumber>, IComparable<RationalNumber>
    {
        int numerator;
        int denominator;

        public RationalNumber(int num, int denom)
        {
            numerator = num;
            denominator = denom;

            var gcd = GreatestCommonDenominator(numerator, denominator);
            numerator /= gcd;
            denominator /= gcd;
        }

        public override string ToString()
        {
            return numerator + "/" + denominator;
        }

        // (from Adam Fall 2020) 
        static int GreatestCommonDenominator(int a, int b)
        {
            if (b == 0)
            {
                return Math.Abs(a);
            }
            else
            {
                return GreatestCommonDenominator(b, a % b);
            }
        }
        public bool Equals(RationalNumber? other)
        {
            if (other == null) return false;
            if (other.numerator / denominator == 1) return true;
            if (other.numerator / denominator == -1) return true;
            else return false;
        }
        public int CompareTo(RationalNumber? other)
        {
            if (other == null) return 0;
            if (other.numerator > denominator) return -1;
            if (other.numerator < denominator) return 1;
            else return 0;
        }
    }
}