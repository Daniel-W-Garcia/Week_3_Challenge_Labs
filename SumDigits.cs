namespace Week_3_Challenge_Labs;

public class SumDigits
{
    string stringToTest;
    int sum;

    public int SumDigitsInString(string input)
    {
        sum = 0;
        foreach (char c in input)
        {
            if (char.IsDigit(c))
            {
                sum += int.Parse(c.ToString());
            }
        }
        Console.WriteLine(sum);
        return sum;
    }
}