namespace _4218;

public class RandomCounter : SimpleCounter
{
    private Random _random = new(Seed: 100);

    public new int NextNumber()
    {
        return _currentCount += _random.Next();
    }
}
