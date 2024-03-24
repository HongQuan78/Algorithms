using System.Text;

public class Program
{
    public static void Main(string[] args)
    {
        string s = "aaabbbcccd";
        string s2 = "aaabbbcccd";
        Console.WriteLine(s);
        Console.WriteLine("1 character 'a'");
        DeletedentifiedDuplicate(ref s, 'a');
        Console.WriteLine(s2);
        Console.WriteLine("All character duplicate:");
        DeleteAllCharacterDuplicate(ref s2);
        Console.WriteLine(s2);
    }

    public static void DeletedentifiedDuplicate(ref string s, char character)
    {

    }


    public static void DeleteAllCharacterDuplicate(ref string s)
    {
        HashSet<char> result = new HashSet<char>();
        for (int i = 0; i < s.Length; i++)
        {
            if (!result.Contains(s[i]))
            {
                result.Add(s[i]);
            }
        }

        string output = String.Join("", result);
        s = output;
    }
}