public class RationalNumber2 : IEquatable<RationalNumber> , IComparable<RationalNumber>
{
    public int denominator;
    public bool Equals(RationalNumber? other)
    {
        if (other / denominator == 1) return true;
        if (other / denominator == -1) return true;
        else return false;
        throw new NotImplementedException();
    }

    public int CompareTo(RationalNumber? other)
    {
        throw new NotImplementedException();
    }
}