using _4218;

namespace _4218_Test;

public class Counter4218
{
    [Fact]
    public void SimpleCounterTest()
    {
        SimpleCounter simpleCounter = new();
        var count1 = simpleCounter.NextNumber();
        var count2 = simpleCounter.NextNumber();
        var count3 = simpleCounter.NextNumber();
        var count4 = simpleCounter.NextNumber();

        Assert.Equal(count1, count2-1);
        Assert.Equal(count2, count3-1);
        Assert.Equal(count3, count4-1);
    }

    [Fact]
    public void ManualCounterTest()
    {
        ManualCounter manualCounter = new();
        manualCounter.Increment();
        var count1 = manualCounter.NextNumber();
        manualCounter.Increment();
        var count2 = manualCounter.NextNumber();
        manualCounter.Increment();
        manualCounter.Decrement();
        var count3 = manualCounter.NextNumber();

        Assert.Equal(1, count1);
        Assert.Equal(count1 + 1, count2);
        Assert.Equal(count2, count3);
    }

    [Fact]
    public void RandomCounterTest()
    {
        Random random = new Random(Seed: 100);
        RandomCounter randomCounter = new();

        var count1 = randomCounter.NextNumber();
        var count2 = randomCounter.NextNumber();
        var count3 = randomCounter.NextNumber();
        var count4 = randomCounter.NextNumber();
        random.Next();

        Assert.Equal(count2-count1, random.Next());
        Assert.Equal(count3-count2, random.Next());
        Assert.Equal(count4-count3, random.Next());
    }

    [Fact]
    public void FibonacciCounterTest()
    {
        FibonacciCounter fibonacciCounter = new();

        var count1 = fibonacciCounter.NextNumber();
        var count2 = fibonacciCounter.NextNumber();
        var count3 = fibonacciCounter.NextNumber();
        var count4 = fibonacciCounter.NextNumber();
        var count5 = fibonacciCounter.NextNumber();
        var count6 = fibonacciCounter.NextNumber();
        var count7 = fibonacciCounter.NextNumber();
        var count8 = fibonacciCounter.NextNumber();
        var count9 = fibonacciCounter.NextNumber();
        var count10 = fibonacciCounter.NextNumber();


        Assert.Equal(0, count1);
        Assert.Equal(1, count2);
        Assert.Equal(1, count3);
        Assert.Equal(2, count4);
        Assert.Equal(3, count5);
        Assert.Equal(5, count6);
        Assert.Equal(8, count7);
        Assert.Equal(13, count8);
        Assert.Equal(21, count9);
        Assert.Equal(34, count10);
    }

    [Fact]
    public void StepCounterTest()
    {
        StepCounter stepCounter = new(2);

        var count1 = stepCounter.NextNumber();
        var count2 = stepCounter.NextNumber();
        var count3 = stepCounter.NextNumber();
        var count4 = stepCounter.NextNumber();

        Assert.Equal(2, count2-count1);
        Assert.Equal(2, count3-count2);
        Assert.Equal(2, count4-count3);
    }
}

