using System;

class Program
{
    static int BinarySearch(int[] array, int target)
    {
        int left = 0, right = array.Length - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2; 

            if (array[mid] == target)
                return mid;
            if (array[mid] < target)
                left = mid + 1; 
            else
                right = mid - 1; 
        }
        return -1; 
    }

    static void Main()
    {
        Console.Write("Dizi elemanlarını artan sırada boşluklu girin: ");
        int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse); 

        Console.Write("Aranacak elemanı girin: ");
        int target = int.Parse(Console.ReadLine()); 

        int result = BinarySearch(arr, target);

        if (result != -1)
            Console.WriteLine($"Eleman bulundu! İndeks: {result}");
        else
            Console.WriteLine("Eleman bulunamadı.");
    }
}
