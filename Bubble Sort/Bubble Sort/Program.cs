class Program
{
    public static void Main(string[] args)
    {
        int[] array = { 29, 10, 14, 37, 14 };
        Console.WriteLine("Before");
        foreach (var item in array)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
        Console.WriteLine("After");

        BubbleSort(array);
        foreach (var item in array)
        {
            Console.Write(item + " ");
        }
    }

    public static void BubbleSort(int[] array)
    {
        bool swapped;
        do
        {
            swapped = false;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i - 1] > array[i])
                {
                    Swap(ref array[i - 1], ref array[i]);
                    swapped = true;
                }
            }
        } while (swapped);
    }

    public static void Swap(ref int a, ref int b)
    {
        (b, a) = (a, b);
    }
}