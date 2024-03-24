
class Program
{
    public static void Main(string[] args)
    {
        int[] array = { 4, 48, 34, 2, 39, 20, 8, 20, 9, 17 };
        Console.WriteLine("Before");
        foreach (var item in array)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();

        Console.WriteLine("After");

        SelectionSort(array);
        foreach (var item in array)
        {
            Console.Write(item + " ");
        }
    }

    public static void SelectionSort(int[] array)
    {
        int i = 0;
        int minimum;
        while (i < array.Length) 
        {
            minimum = i;
            for (int j = i; j < array.Length; j++) 
            {
                if (array[j] < array[minimum])
                {
                    minimum = j;
                }
            }
            Swap(ref array[i], ref array[minimum]);
            i++;
        }
    }
    public static void Swap(ref int a, ref int b)
    {
        (a, b) = (b, a);
    }
}