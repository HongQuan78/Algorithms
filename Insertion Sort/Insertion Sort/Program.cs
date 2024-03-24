
class Program
{
    public static void Main(string[] args)
    {
        int[] array = [90, 8, 28, 22, 44, 17, 21, 31, 45, 21];
        Console.WriteLine("Before");
        foreach (var item in array)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();

        Console.WriteLine("After");

        InsertionSort(array);
        foreach (var item in array)
        {
            Console.Write(item + " ");
        }
    }

    public static void InsertionSort(int[] array)
    {
        for (int i = 1; i < array.Length; i++)
        {
            int key = array[i];
            int j = i - 1;
            while (j >= 0 && array[j] > key)
            {
                array[j + 1] = array[j];
                j--;
            }

            array[j + 1] = key;
        }
    }

}