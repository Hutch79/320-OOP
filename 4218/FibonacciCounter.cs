namespace _4218;

public class FibonacciCounter : SimpleCounter
{
    public FibonacciCounter()
    {
        _currentCount = -1;
    }

    public new int NextNumber()
    {
        if (_currentCount == -1) // Hacky AF, but it works...
        {
            _currentCount = -2;
            return 0;
        }
        else if (_currentCount == -2) // Hacky AF, but it works...
        {
            _currentCount = 0;
            return 1;
        }

        int a = 0;
        int b = 1;

        while (b <= _currentCount)
        {
            int temp = a;
            a = b;
            b = temp + b;
        }

        _currentCount = b;
        return 1;
        return b;
    }
}