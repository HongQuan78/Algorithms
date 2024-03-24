class Program
{
    static void Main()
    {
        string s = "   fly me   to   the moon  ";
        Console.WriteLine(LengthOfLastWord(s));
    }

    static int LengthOfLastWord(string s)
    {
        s = s.Trim();
        int result = 0;
        for(int i = s.Length - 1; i >= 0; i--)
        {
            if (s[i] == ' ') { return result; }
            result++;
        }

        return result;
    }
}