namespace _4218;

public class ManualCounter : SimpleCounter
{
    public void Increment()
    {
        ++_currentCount;
    }

    public void Decrement()
    {
        --_currentCount;
    }

    public new int NextNumber()
    {
        return _currentCount;
    }
}
