namespace Week_3_Challenge_Labs;

public class EditString
{
    public int MinLength(string s)
    {
        Console.WriteLine($"""
                           The string {s};
                           With a length of {s.Length} becomes:
                           
                           """);
        bool madeChange = true;
        
        while (madeChange)
        {
            int oldLength = s.Length;
            
            s = s.Replace("AB", "");
            s = s.Replace("CD", "");
            
            madeChange = (s.Length < oldLength);
        }

        Console.WriteLine($"""
                          {s}
                          With a length of {s.Length};
                          
                          """);
        return s.Length;
    }
}