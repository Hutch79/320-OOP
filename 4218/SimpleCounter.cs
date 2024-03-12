namespace _4218;

public class SimpleCounter
{
    protected int _currentCount;

    public int CurrentCount
    {
        get => _currentCount;
        set => _currentCount = value;
    }

    public int NextNumber()
    {
        return _currentCount++;
    }
}
