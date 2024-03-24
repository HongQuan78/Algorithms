class Program
{
    static void Main()
    {
        int[] array = [3, 2, 4];
        int target = 6;
        int[] result = new int[2];
        result = TwoSum(target, array);
        foreach (int x in result)
        {
            Console.WriteLine(x);
        }
    }

    //static int[] TwoSum(int target, int[] nums)
    //{
    //    int sum = 0;
    //    int[] result = new int[2];
    //    for (int i = 0; i < nums.Length; i++)
    //    {
    //        for (int j = 0; j < nums.Length; j++)
    //        {
    //            if (i != j)
    //            {
    //                sum += nums[i] + nums[j];
    //                if (sum == target)
    //                {
    //                    result[0] = i;
    //                    result[1] = j;
    //                }
    //                sum = 0;
    //            }
    //        }
    //    }
    //    return result;
    //}


    static int[] TwoSum(int target, int[] nums)
    {
        Dictionary<int, int> map = new Dictionary<int, int>();
        int num;
        for (int i = 0; i < nums.Length; i++)
        {
            num = target - nums[i];
            if (map.TryGetValue(num, out int value))
            {
                return new int[] { value, i };
            }
            if (!map.TryAdd(nums[i], i))
            {
                continue;
            }
        }
        return null;
    }
}