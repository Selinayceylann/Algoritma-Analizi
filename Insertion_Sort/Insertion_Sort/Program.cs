using System;
using System.Diagnostics;

// Kullanıcıdan alınan bir diziyi artan veya azalan şekilde sıralar ve sıralama süresini ölçerek ekrana yazdırır.
class Program
{
    static void InsertionSort(int[] array, bool ascending = true)
    {
        int n = array.Length;
        for (int i = 1; i < n; i++)
        {
            int key = array[i];
            int j = i - 1;

            while (j >= 0 && (ascending ? array[j] > key : array[j] < key))
            {
                array[j + 1] = array[j];
                j--;
            }
            array[j + 1] = key;
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

        Stopwatch stopwatch = Stopwatch.StartNew(); 
        InsertionSort(arr, ascending);
        stopwatch.Stop(); 

        Console.WriteLine("Sıralanmış Dizi:");
        PrintArray(arr);

        Console.WriteLine($"Sıralama süresi: {stopwatch.ElapsedMilliseconds} ms"); 
    }
}
