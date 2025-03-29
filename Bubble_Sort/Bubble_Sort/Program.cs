using System;

class Program
{
    static void BubbleSort(int[] array, bool ascending = true)
    {
        int n = array.Length;
        bool swapped;

        for (int i = 0; i < n - 1; i++)
        {
            swapped = false;
            for (int j = 0; j < n - i - 1; j++)
            {
                if ((ascending && array[j] > array[j + 1]) || (!ascending && array[j] < array[j + 1]))
                {
                    (array[j], array[j + 1]) = (array[j + 1], array[j]);
                    swapped = true;
                }
            }
            if (!swapped) break;
        }
    }

    static void PrintArray(int[] array)
    {
        Console.WriteLine(string.Join(" ", array));
    }

    static void Main()
    {
        Console.Write("Dizi elemanlarını boşluklu girin: ");
        int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse); 

        Console.Write("Artan sıralama için 'A', azalan için 'D' girin: ");
        bool ascending = Console.ReadLine().Trim().ToUpper() == "A"; 

        BubbleSort(arr, ascending); 

        Console.WriteLine("Sıralanmış Dizi:");
        PrintArray(arr);
    }
}
