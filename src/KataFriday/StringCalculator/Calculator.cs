
public class Calculator
{

    public int Add(string numbers)
    {
        if (string.IsNullOrEmpty(numbers))
        {
            return 0;
        }

        var delimiters = new List<char> { ',', '\n' };

        // Check for custom delimiter format: "//<delimiter>\n"
        if (numbers.StartsWith("//"))
        {
            var customDelimiter = numbers[2];
            delimiters.Add(customDelimiter);
            numbers = numbers.Substring(4); // Remove the "//<delimiter>\n" part
        }

        var separated = numbers.Split(delimiters.ToArray());

        int total = 0;

        var negatives = new List<int>();

        foreach (var part in separated)
        {
            int number = int.Parse(part);
            if (number < 0)
            {
                negatives.Add(number);
            }
            total += int.Parse(part);
        }

        if (negatives.Count > 0)
        {
            throw new ArgumentException("this is a negative");
        }

        return total;
    }
}

