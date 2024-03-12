namespace _4218;

public class StepCounter : SimpleCounter
{
    private int _step;
    public StepCounter(int stepSIze = 1)
    {
        _step = stepSIze;
    }

    public new int NextNumber()
    {
        return _currentCount += _step;
    }
}
