using System.Collections;
/// <summary>
/// Class that implements IEnumerable and generates random float numbers.
/// Throws an InvalidSequenceException if three consecutive numebrs are <= 0.5
/// </summary>
public class RandomFloatGenerator : IEnumerable<float>
{
    private Random _random = new Random();

    public IEnumerator<float> GetEnumerator()
    {
        int count = 0;
        while (true)
        {
            float value = (float)_random.NextDouble();
            yield return value;

            count = value <= 0.5f ? count + 1 : 0;

            if (count >= 3)
            {
                throw new InvalidSequenceException("Three consecutive numbers were ≤ 0.5");
            }
        }
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}