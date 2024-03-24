using System.Xml;

class Program
{
    static void Main()
    {
        Console.WriteLine(IsPalindrome(120));
    }

    public static bool IsPalindrome(int x)
    {
        if(x <= 100)
        {
            return false;
        }

        string s = x.ToString();
        var result = new string(s.Reverse().ToArray());
        var x2 = int.Parse(result.ToString());
        if(x2 == x)
        {
            return true;
        }
        return false;
    }
}