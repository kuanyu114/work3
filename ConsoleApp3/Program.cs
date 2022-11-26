//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

string s = "A man, a plan, a canal: Panama";
var result = new Solution().IsPalindrome(s);
Console.WriteLine(result);

public class Solution
{
    public bool IsPalindrome(string s)
    {
        
        if(s.Length== 1 || s == " ") return true;

        bool result = true;
        List<char> after = new List<char>();
        
        foreach (var item in s)
        {            
            if (char.IsLetterOrDigit(item))
            {
                after.Add( char.ToLower(item));
            }
        }
        for (int i = 0; i < after.Count()/2; i++)
        {
            if (after[i] != after[after.Count() - i - 1])
            {
                result = false;
                break;
            }

        }

        return result;
    }
}