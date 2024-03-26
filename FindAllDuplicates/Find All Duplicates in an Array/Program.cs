class Program
{
    static void Main()
    {
        int[] nums = [4, 3, 2, 7, 8, 2, 3, 1];
        var list = FindDuplicates(nums);

        foreach (int x in list)
        {
            Console.Write(x + " ");
        }
    }

    static IList<int> FindDuplicates(int[] nums)
    {
        var list = new List<int>();

        var result = new HashSet<int>();

        for (int i = 0; i < nums.Length; i++)
        {
            if (result.Contains(nums[i]))
            {
                list.Add(nums[i]);
            } 
            else
            {
                result.Add(nums[i]);
            }
        }

        return list;
    }
}