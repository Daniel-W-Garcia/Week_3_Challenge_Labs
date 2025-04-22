namespace Week_3_Challenge_Labs;

public class Palindrome
{
    private string stringToTest;
    bool isPalindrome;
    private bool IsPalindrome(string input)
    {
        stringToTest = input.Replace(" ", "");
        isPalindrome = true;
        
        for (int i = 0; i < stringToTest.Length / 2; i++)
        {
            if (stringToTest[i] != stringToTest[stringToTest.Length - i - 1])
            {
                isPalindrome = false;
                break;
            }
            else
            {
                isPalindrome = true;
            }
        }
        return isPalindrome;
    }

    public void PrintResult()
    {
        Console.WriteLine("Please enter a word or phrase to test if it is a palindrome: ");
        stringToTest = Console.ReadLine().ToLower().Trim(' ');
        Console.WriteLine(IsPalindrome(stringToTest));
    }
}