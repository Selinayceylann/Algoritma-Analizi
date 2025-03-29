using System;

class Program
{
    static (int maxSum, int[] subarray) KadaneAlgorithm(int[] array)
    {
        int maxSum = array[0];   
        int currentSum = array[0]; 
        int start = 0;            
        int end = 0;              
        int tempStart = 0;       

        for (int i = 1; i < array.Length; i++)
        {
            if (currentSum + array[i] > array[i])
            {
                currentSum += array[i]; 
            }
            else
            {
                currentSum = array[i];
                tempStart = i;         
            }

            if (currentSum > maxSum)
            {
                maxSum = currentSum; 
                start = tempStart;     // Yeni alt dizinin bitişini güncelle
            }
        }

        int[] subarray = new int[end - start + 1];
        Array.Copy(array, start, subarray, 0, subarray.Length);

        return (maxSum, subarray); 
    }

    static void Main()
    {
        Console.Write("Dizi elemanlarını boşluklu girin: ");
        int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse); 

        var (maxSubarraySum, subarray) = KadaneAlgorithm(arr);

        Console.WriteLine($"Maksimum alt dizi toplamı: {maxSubarraySum}");
        Console.WriteLine("Maksimum alt dizi: " + string.Join(" ", subarray));
    }
}
