

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
    [InlineData("1\n2", 3)]
    [InlineData("1\n2,3", 6)]
    public void MixedDelimiters(string input, int expected)
    {
        var calculator = new Calculator();
        var result = calculator.Add(input);
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("//#\n1#2#3", 6)]
    [InlineData("//#\n1#2,3\n1", 7)]
    public void CustomDelimiter(string input, int expected)
    {
        var calculator = new Calculator();
        var result = calculator.Add(input);
        Assert.Equal(expected, result);
    }


    [Fact]
    public void NeagtivesException()
    {
        var calculator = new Calculator();

        var exception = Assert.Throws<ArgumentException>(() => calculator.Add("1,-2,3"));

        Assert.Equal("this is a negative", exception.Message);
    }




}

