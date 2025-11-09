namespace TestProject1;

public class Tests
{
    [Test]
    public void Test1()
    {
        var test = new Calculator.Calculator(2, 2, '+');
        Assert.That(test.Calculate(), Is.EqualTo(4));
    }

    [Test]
    public void Test2()
    {
        var test = new Calculator.Calculator(4, 2, '-');
        Assert.That(test.Calculate(), Is.EqualTo(2));
    }

    [Test]
    public void Test3()
    {
        var test = new Calculator.Calculator(10, 5, '*');
        Assert.That(test.Calculate(), Is.EqualTo(50));
    }

    [Test]
    public void Test4()
    {
        var test = new Calculator.Calculator(10, 5, '/');
        Assert.That(test.Calculate(), Is.EqualTo(2));
    }

    [Test]
    public void TestDivisionByZero()
    {
        var test = new Calculator.Calculator(10, 0, '/');
        Assert.Throws<DivideByZeroException>(() => test.Calculate());
    }

    [Test]
    public void TestInvalidOperation()
    {
        var test = new Calculator.Calculator(50, 10, '%');
        Assert.Throws<InvalidOperationException>(() => test.Calculate());
    }

    [Test]
    public void TestNeg()
    {
        var test = new Calculator.Calculator(2, -4, '+');
        Assert.That(test.Calculate(), Is.EqualTo(-2));
    }

    [Test]
    public void TestDecimal()
    {
        var test = new Calculator.Calculator(2, 3, '/');
        Assert.That(test.Calculate(), Is.EqualTo(0.667).Within(0.001));
    }

    [Test]
    public void TestLast()
    {
        var test = new Calculator.Calculator(12.5, 0.5, '*');
        Assert.That(test.Calculate(), Is.EqualTo(6.25));
    }
}