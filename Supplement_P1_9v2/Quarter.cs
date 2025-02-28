namespace Supplement_P1_9v2;
/// <summary>
///A quarter in the range [0.0, 1.0) that provides the operator overloading for comparison.
/// </summary>
public class Quarter
{
    private float value;
    /// <summary>
    /// Initializes a new instance of the Quarter class with a specified value.
    /// </summary>
    /// <param name="value">A float number with the range of 0.0-1.0</param>
    /// <exception cref="ArgumentOutOfRangeException">Throw if value is outside the specified range.</exception>
    public Quarter(float value)
    {
        if (value < 0.0f || value >= 1.0f)
            throw new ArgumentOutOfRangeException(nameof(value), "Value must be in range [0.0, 1.0)");
        this.value = value;
    }
    private int GetQuarter() => (int)(value * 4);

    public static bool operator ==(Quarter q1, Quarter q2) => q1?.GetQuarter() == q2?.GetQuarter();
    public static bool operator !=(Quarter q1, Quarter q2) => !(q1 == q2);
    public static bool operator >(Quarter q1, Quarter q2) => q1.value > q2.value;
    public static bool operator <(Quarter q1, Quarter q2) => q1.value < q2.value;
    public static bool operator >=(Quarter q1, Quarter q2) => q1.value >= q2.value;
    public static bool operator <=(Quarter q1, Quarter q2) => q1.value <= q2.value;
    
    public override bool Equals(object obj) => obj is Quarter q && this == q;
    public override int GetHashCode() => GetQuarter().GetHashCode();
}
