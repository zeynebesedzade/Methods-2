
//using System;

//class Program
//{
//    public static int Min(int[] array)
//    {
//        if (array.Length == 0) return 0;

//        int min = array[0];
//        for (int i = 1; i < array.Length; i++)
//            if (array[i] < min)
//                min = array[i];

//        return min;
//    }

//    static void Main()
//    {
//        int[] numbers = { 5, 2, 8, 1, 9, 3 };
//        Console.WriteLine("En kiçik element: " + Min(numbers));
//    }
//}


using System;

class Program
{
    //cevrenin sahesi
    public static int Area(int r)
    {
        int p = 3;
        return p * r * r;
    }

    // Düzbucaqlının sahesi 
    public static int Area(int a, int b)
    {
        return a * b;
    }

    // Düzbucaqlı paralelpipedin tam səthinin sahesi 
    public static int Area(int a, int b, int c)
    {
        return 2 * (a * b + a * c + b * c);
    }

    // Üçbucaqlının daxiline çekilmiş çevrenin sahesi 
    public static int Area(int a, int b, int c, int r)
    {
        int p = (a + b + c) / 2;
        return p * r;
    }

    static void Main()
    {
        Console.WriteLine("Çevrenin sahesi: " + Area(8));
        Console.WriteLine("Düzbucaqlının sahesi: " + Area(4, 6));
        Console.WriteLine("Düzbucaqlı paralelpipedin tam sethinin sahesi: " + Area(3, 5, 7));
        Console.WriteLine("Üçbucaqlının daxiline çekilmiş çevrenin sahesi: " + Area(3, 4, 8, 2));
    }
}


