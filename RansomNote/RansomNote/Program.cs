class Program
{
    static void Main()
    {
        string ransomNote = "ac";
        string magazine = "ab";
        Console.WriteLine(CanConstruct(ransomNote, magazine));
    }

    static bool CanConstruct(string ransomNote, string magazine)
    {
        Dictionary<char, int> magazineMap = new Dictionary<char, int>();

        for (int i = 0; i < magazine.Length; i++)
        {
            if (!magazineMap.ContainsKey(magazine[i]))
            {
                magazineMap.Add(magazine[i], 1);
            }
            else
            {
                magazineMap[magazine[i]]++;
            }
        }

        Dictionary<char, int> ransomNoteMap = new Dictionary<char, int>();

        for (int i = 0; i < ransomNote.Length; i++)
        {
            if (!ransomNoteMap.ContainsKey(ransomNote[i]))
            {
                ransomNoteMap.Add(ransomNote[i], 1);
            }
            else
            {
                ransomNoteMap[ransomNote[i]]++;
            }
        }

        int numberOfWord = ransomNoteMap.Count;
        var enumerator = ransomNoteMap.GetEnumerator();
        while (numberOfWord > 0)
        {
            var item = enumerator.Current;
            if (magazineMap.ContainsKey(item.Key) && magazineMap[item.Key] < item.Value)
            {
                return false;
            }
            numberOfWord--;

        }
        return true;
    }
}