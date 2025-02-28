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
            while (count < 3)
            {
                enumerator.MoveNext();
                if (enumerator.Current <= 0.5f)
                    count++;
                else
                    count = 0;
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
}
