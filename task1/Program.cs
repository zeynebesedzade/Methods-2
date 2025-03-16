
using System;

class Program
{
    public static int Min(int[] array)
    {
        if (array.Length == 0) return 0;

        int min = array[0];
        for (int i = 1; i < array.Length; i++)
            if (array[i] < min)
                min = array[i];

        return min;
    }

    static void Main()
    {
        int[] numbers = { 5, 2, 8, 1, 9, 3 };
        Console.WriteLine("En kiçik element: " + Min(numbers));
    }
}
