

namespace StringCalculator;
public class CalculatorTests
{
    [Fact]
    public void EmptyStringReturnsZero()
    {
        var calculator = new Calculator();

        var result = calculator.Add("");

        Assert.Equal(0, result);
    }
    [Theory]
    [InlineData("3", 3)]

    public void CanAddASingleInteger(string value, int expected)
    {
        var calculator = new Calculator();
        var result = calculator.Add(value);
        Assert.Equal(expected, result);
    }
    [Fact]
    public void SingleNumberReturnsValue()
    {
        var calculator = new Calculator();
        var result = calculator.Add("2");

        Assert.Equal(2, result);
    }
    [Theory]
    [InlineData("3,7", 10)]
    public void Separated(string value, int expected)
    {
        var calculator = new Calculator();
        var result = calculator.Add(value);
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("1,2", 3)]
    [InlineData("1,2,3,4", 10)]

    public void multipleSeparated(string value, int expected)
    {
        var calculator = new Calculator();
        var result = calculator.Add(value);
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("1\n2", 3)]
    [InlineData("1\n2,3", 6)]
    public void Add_ReturnsCorrectSum_WithMixedDelimiters(string input, int expected)
    {
        var calculator = new Calculator();

        var result = calculator.Add(input);

        Assert.Equal(expected, result);
    }


}
