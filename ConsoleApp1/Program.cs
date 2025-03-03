
using System;

class Program
{
    static void Main()
    {
        Execute();
    }

    static void Execute()
    {
        int[] arr = InitArray();
        int maxIndex = GetMaxIndex(arr);
        int minIndex = GetMinIndex(arr);
        PrintArray("Исходный массив:", arr);
        PrintLine("Максимальный элемент: " + arr[maxIndex] + ", индекс: " + maxIndex);
        PrintLine("Минимальный элемент: " + arr[minIndex] + ", индекс: " + minIndex);
        Swap(arr, maxIndex, minIndex);
        PrintArray("Массив после обмена:", arr);
        PrintLine("Количество элементов между максимальным и минимальным: " + CountBetween(maxIndex, minIndex));
    }

    static int[] InitArray()
    {
        return new int[] { 5, 12, 3, 7, 19, 2, 8, 14, 6, 1 };
    }

    static int GetMaxIndex(int[] a)
    {
        int index = 0;
        for (int i = 1; i < a.Length; i++)
        {
            if (a[i] > a[index])
            {
                index = i;
            }
        }
        return index;
    }

    static int GetMinIndex(int[] a)
    {
        int index = 0;
        for (int i = 1; i < a.Length; i++)
        {
            if (a[i] < a[index])
            {
                index = i;
            }
        }
        return index;
    }

    static void Swap(int[] a, int i, int j)
    {
        int temp = a[i];
        a[i] = a[j];
        a[j] = temp;
    }

    static int CountBetween(int i, int j)
    {
        return Math.Abs(i - j) - 1;
    }

    static void PrintArray(string msg, int[] a)
    {
        Console.WriteLine(msg);
        Console.WriteLine(string.Join(" ", a));
    }

    static void PrintLine(string s)
    {
        Console.WriteLine(s);
    }
}
