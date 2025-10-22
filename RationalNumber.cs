public class RationalNumber : IEquatable<RationalNumber> , IComparable<RationalNumber>
{
    public int numerator;
    public int denominator;
    public bool Equals(RationalNumber? other)
    {
        if (other == numerator || denominator) return true;
        if (other =! numerator || denominator) return false;
        throw new NotImplementedException();
    }

    public int CompareTo(RationalNumber? other)
    {
        if (other / numerator || denominator== 1) return 1;
        if (other / == -1) return -1;
        if (other / == 0) return 0;
        throw new NotImplementedException();
    }
}