namespace Supplement_P1_9v2.Tests;

public class UnitTest1
{
    [Fact]
public void TestInvalidSequenceException()
{
    var generator = new RandomFloatGenerator();
    var enumerator = generator.GetEnumerator();

    Assert.Throws<InvalidSequenceException>(() =>
    {
        int count = 0;
        int iterations = 0;
        while (iterations < 100)  
        {
            enumerator.MoveNext();
            if (enumerator.Current <= 0.5f)
                count++;
            else
                count = 0;

            if (count >= 3)
                throw new InvalidSequenceException("Three consecutive numbers were ≤ 0.5");

            iterations++;
        }
    });
}


    [Fact]
    public void TestQuarterEquality()
    {
        var q1 = new Quarter(0.1f);
        var q2 = new Quarter(0.2f);
        var q3 = new Quarter(0.3f);

        Assert.True(q1 == q2);
        Assert.False(q1 == q3);
    }
    [Fact]
    
    public void TestQuarterComparisons()
    {
        var q1 = new Quarter(0.1f);
        var q2 = new Quarter(0.3f);
        var q3 = new Quarter(0.6f);

        Assert.True(q1 < q2);
        Assert.True(q3 > q2);
        Assert.True(q1 <= q2);
        Assert.True(q3 >= q2);
    }
}
