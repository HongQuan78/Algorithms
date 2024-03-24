class Program
{
    static void Main()
    {
        int[] nums = [3, 2, 2, 3];
        int val = 3;
        RemoveElement(nums, val);
    }

    static int RemoveElement(int[] nums, int val)
    {
        int k = 0; 
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != val)
            {
                nums[k] = nums[i]; 
                k++; 
            }
        }
        return k;
    }
}