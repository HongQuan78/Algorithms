using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main()
    {
        Console.WriteLine(LongestCommonPrefix(["flower", "flow", "flight"]));
    }

    static string LongestCommonPrefix(string[] strs)
    {
        if (strs.Length == 0) return "";
        if(strs.Length == 1) return strs[0];
        string result = "";
        for (int i = 0; i < strs[0].Length; i++)
        {
            for (int j = 1; j < strs.Length; j++)
            {
                if (i >= strs[j].Length || strs[j][i] != strs[0][i])
                {
                    return result;
                }
            }

            result += strs[0][i];
        }
        return result;
    }
}