
using System.Numerics;

public class Calculator
{
    public int Add(string numbers)
    {
        if (string.IsNullOrEmpty(numbers))
        {
            return 0;
        }

        var delimiters = new List<char> { ',', '\n' };

        if (numbers.StartsWith("//"))
        {

        }


        var separated = numbers.Split(newLineArray);



        int total = 0;

        foreach ( var i  in separated )
        {
            total = total + int.Parse( i );
        }



        return total;
    }
}
