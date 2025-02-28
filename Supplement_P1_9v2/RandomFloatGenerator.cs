using System.Collections;

public class RandomFloatGenerator : IEnumerable<float>
{
    private Random _random = new Random();
    public IEnumerator<float> GetEnumerator()
    {
        throw new NotImplementedException();
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}