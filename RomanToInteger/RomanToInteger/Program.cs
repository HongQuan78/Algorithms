class Program
{
    static void Main()
    {
        string s = "MMMXLV";
        Console.WriteLine(RomanToInt(s));
    }

    static int RomanToInt(string s)
    {
        int result = 0;
        HashSet<char> validChars = new() { 'I', 'V', 'X', 'L', 'C', 'D', 'M' };
        if (!s.All(c => validChars.Contains(c)))
        {
            throw new Exception("Invalid Input");
        }

        Dictionary<string, int> romanMap = new()
        {
            { "I", 1 },
            { "V", 5 },
            { "X", 10 },
            { "L", 50 },
            { "C", 100 },
            { "D", 500 },
            { "M", 1000 },
            { "IV", 4 },
            { "IX", 9 },
            { "XL", 40},
            { "XC", 90 },
            { "CD", 400 },
            { "CM", 900 }

        };
        for (int i = 0; i < s.Length; i++)
        {
            char character = s[i];
            if(i != s.Length - 1)
            {
                if (romanMap.TryGetValue(s.Substring(i, 2), out int value))
                {
                    result += value;
                    i ++;
                    continue;
                }
            }
            if (romanMap.ContainsKey(character.ToString()))
            {
                result += romanMap[character.ToString()];
            }
        }
        return result;
    }
}