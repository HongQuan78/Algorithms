using System;

class Program
{
    static void Main()
    {
        int[] nums1 = { 1, 2, 3, 0, 0, 0 };
        int m = 3;
        int[] nums2 = { 2, 5, 6 };
        int n = 3;

        Merge(nums1, m, nums2, n);

        Console.WriteLine("Merged Array: [" + string.Join(", ", nums1) + "]");
    }

    static void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        int k = m + n - 1;

        for (int i = m - 1; i < nums1.Length; i++)
        {
            for (int j = n; j >= 0; j--) 
            {
                nums1[i] = nums2[j];
            }
        }

    }
}
