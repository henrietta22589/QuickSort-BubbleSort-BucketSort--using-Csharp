//Bubble short
//using System;
//public class Bubble_Sort
//{
//    //public static void Main(string[] args)
//{
//    int[] a = { 3, 0, 2, 5, -1, 4, 1 };
//    int t;
//    Console.WriteLine("Original array :");
//    foreach (int aa in a)
//        Console.Write(aa + " ");
//    for (int p = 0; p <= a.Length - 2; p++)
//    {
//        for (int i = 0; i <= a.Length - 2; i++)
//        {
//            if (a[i] > a[i + 1])
//            {
//                t = a[i + 1];
//                a[i + 1] = a[i];
//                a[i] = t;
//            }
//        }
//    }
//    Console.WriteLine("\n" + "Sorted array :");
//    foreach (int aa in a)
//        Console.Write(aa + " ");
//    Console.Write("\n");
//}

using System;
class GFG
{
    /* This function takes last element as pivot, 
    places the pivot element at its correct 
    position in sorted array, and places all 
    smaller (smaller than pivot) to left of 
    pivot and all greater elements to right 
    of pivot */
    static int partition(int[] arr, int low, int high)
    {
        int pivot = arr[high];
        // index of smaller element 
        int i = (low - 1);
        for (int j = low; j < high; j++)
        {
            // If current element is smaller  
            // than the pivot 
            if (arr[j] < pivot)
            {
                i++;
                // swap arr[i] and arr[j] 
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
        }
        // swap arr[i+1] and arr[high] (or pivot) 
        int temp1 = arr[i + 1];
        arr[i + 1] = arr[high];
        arr[high] = temp1;
        return i + 1;
    }
    /* The main function that implements QuickSort() 
    arr[] --> Array to be sorted, 
    low --> Starting index, 
    high --> Ending index */
    static void quickSort(int[] arr, int low, int high)
    {
        if (low < high)
        {
            /* pi is partitioning index, arr[pi] is  
            now at right place */
            int pi = partition(arr, low, high);
            // Recursively sort elements before 
            // partition and after partition 
            quickSort(arr, low, pi - 1);
            quickSort(arr, pi + 1, high);
        }
    }
    // A utility function to print array of size n 
    static void printArray(int[] arr, int n)
    {
        for (int i = 0; i < n; ++i)
            Console.Write(arr[i] + " ");
        Console.WriteLine();
    }
    // Driver program 
    public static void Main()
    {
        int[] arr = { 10, 7,8, 9, 1, 5 };
        int n = arr.Length;
        quickSort(arr, 0, n - 1);
        Console.WriteLine("sorted array ");
        printArray(arr, n);
    }
}


//}
//using System;
//using System.Collections.Generic;
//class GFG
//{
//    public static void Main()
//    {

//        GFG fG =new GFG();
//        fG.SortArrayWithBucketSort();

//    }





//    private void SortArrayWithBucketSort()
//    {
//        double[] array = { 0.37, 0.25, 0.86, 0.23, 0.09, 0.21, 0.17, 0.71 };
//        double[] sortedArray = BucketSort(array);
//        foreach (var item in array)
//        {
//            Console.WriteLine(item);
//        }
//        // PrintResult(sortedArray);
//    }
//    public double[] BucketSort(double[] array)
//    {
//        List<List<double>> buckets = new List<List<double>>();
//        InitializeBuckets(buckets);
//        Scatter(array, buckets);
//        int i = 0;
//        foreach (List<double> bucket in buckets)
//        {
//            double[] arr = bucket.ToArray();
//            InsertionSort(arr);
//            foreach (double d in arr)
//            {
//                array[i++] = d;
//            }
//        }
//        return array;
//    }
//    private void Scatter(double[] array, List<List<double>> buckets)
//    {
//        foreach (double value in array)
//        {
//            int bucketNumber = GetBucketNumber(value);
//            buckets[bucketNumber].Add(value);
//        }
//    }
//    private void InsertionSort(double[] array)
//    {
//        int j;
//        double temp;
//        for (int i = 1; i < array.Length; i++)
//        {
//            j = i;
//            while (j > 0 && array[j] < array[j - 1])
//            {
//                temp = array[j];
//                array[j] = array[j - 1];
//                array[j - 1] = temp;
//                j--;
//            }
//        }
//    }
//    private int GetBucketNumber(double value)
//    {
//        double val = value * 10;
//        int bucketNumber = (int)Math.Floor(val);
//        return bucketNumber;
//    }
//    private static void InitializeBuckets(List<List<double>> buckets)
//    {
//        for (int i = 0; i < 10; i++)
//        {
//            List<double> a = new List<double>();
//            buckets.Add(a);
//        }
//    }
//}






// This code is contributed by Sam007.
