using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.ShortingAlgorithms
{
    public static class QuickShort
    {
    public    static void quickSortOrderByColor(this List<TShirt> shirts, int low, int high)
        {
            if (low < high)
            {
                /* pi is partitioning index, arr[pi] is  
                now at right place */
                int pi = partitionOrderByColor(shirts, low, high);
                // Recursively sort elements before 
                // partition and after partition 
                quickSortOrderByColor(shirts, low, pi - 1);
                quickSortOrderByColor(shirts, pi + 1, high);
            }
        }
       public static int partitionOrderByColor(this List<TShirt> shirts, int low, int high)
        {
            TShirt pivot = shirts[high];
            // index of smaller element 
            int i = (low - 1);
            for (int j = low; j < high; j++)
            {
                // If current element is smaller  
                // than the pivot 
                if (shirts[j].Color < pivot.Color)
                {
                    i++;
                    // swap arr[i] and arr[j] 
                    TShirt temp = shirts[i];
                    shirts[i] = shirts[j];
                    shirts[j] = temp;
                }
            }
            // swap arr[i+1] and arr[high] (or pivot) 
            TShirt temp1 = shirts[i + 1];
            shirts[i + 1] = shirts[high];
            shirts[high] = temp1;
            return i + 1;
        }

        public static void quickSortOrderBySize(this List<TShirt> shirts, int low, int high)
        {
            if (low < high)
            {
                /* pi is partitioning index, arr[pi] is  
                now at right place */
                int pi = partitionOrderBySize(shirts, low, high);
                // Recursively sort elements before 
                // partition and after partition 
                quickSortOrderBySize(shirts, low, pi - 1);
                quickSortOrderBySize(shirts, pi + 1, high);
            }
        }

        public static int partitionOrderBySize(this List<TShirt> shirts, int low, int high)
        {
            TShirt pivot = shirts[high];
            // index of smaller element 
            int i = (low - 1);
            for (int j = low; j < high; j++)
            {
                // If current element is smaller  
                // than the pivot 
                if (shirts[j].Size < pivot.Size)
                {
                    i++;
                    // swap arr[i] and arr[j] 
                    TShirt temp = shirts[i];
                    shirts[i] = shirts[j];
                    shirts[j] = temp;
                }
            }
            // swap arr[i+1] and arr[high] (or pivot) 
            TShirt temp1 = shirts[i + 1];
            shirts[i + 1] = shirts[high];
            shirts[high] = temp1;
            return i + 1;
        }
    }
}
