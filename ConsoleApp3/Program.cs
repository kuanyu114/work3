//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

string s = "A man, a plan, a canal: Panama";
var result = new Solution().IsPalindrome(s);
Console.WriteLine(result);

public class Solution
{
    public bool IsPalindrome(string s)
    {
        bool result = true;
        string after = "";
        s = s.ToLower();
        foreach (var item in s)
        {
            if ((item >= 97 && item <= 122) || (item >= 48 && item <= 57))
            {
                after += item;
            }
        }
        for (int i = 0; i < after.Length/2; i++)
        {
            if (after[i] != after[after.Length - i - 1])
            {
                result = false;
                break;
            }

        }

        return result;
    }
}