class Program
{
    static void Main()
    {
        int[] nums = [3, 3, 3, 3, 3];
        Console.WriteLine(FindDuplicate(nums));
    }

    static int FindDuplicate(int[] nums)
    {
        HashSet<int> result = new();
        foreach (int x in nums)
        {
            if (result.Contains(x))
            {
                return x;
            }
            result.Add(x);
        }
        return 0;
    }
}