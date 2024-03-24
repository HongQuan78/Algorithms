
class Program
{
    static void Main()
    {
        string needle = "issipi";
        string haystack = "mississippi";
        Console.WriteLine(StrStr(haystack, needle));
    }

    static int StrStr(string haystack, string needle)
    {
        if(needle.Length > haystack.Length)
        {
            return -1;
        }
        for (int i = 0; i < haystack.Length; i++)
        {
            if (haystack[i] == needle[0])
            {
                if(needle.Length + i > haystack.Length)
                {
                    return -1;
                }
                for (int j = i; j < needle.Length + i; j++)
                {
                    if (!(haystack[j] == needle[j - i])) { break; }
                    if(j == (needle.Length + i) - 1)
                    {
                        return i;
                    } 
                }
            }
        }
        return -1;
    }
}