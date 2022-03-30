using ConsoleApp.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.ShortingAlgorithms
{
    public static class BucketShort
    {


        public static List<TShirt> BucketSortByColor(this List<TShirt> shirts)
        {

            List<List<TShirt>> buckets = new List<List<TShirt>>();
            InitializeBuckets(buckets);
            Scatter(shirts, buckets);
            int i = 0;
            foreach (List<TShirt> bucket in buckets)
            {
                List<TShirt> shirt = bucket.ToList();
                InsertionSort(shirt);
                foreach (TShirt d in shirt)
                {
                    shirts[i++] = d;
                }
            }
            return shirts;
        }
        //Προσθετει το μπλουζακι στην αντιστοιχη θεση με το χρωμα του!
        private static void Scatter(this List<TShirt> shirts, List<List<TShirt>> buckets)
        {
            foreach (TShirt value in shirts)
            {
                int bucketNumber = GetBucketNumber(value);
                buckets[bucketNumber].Add(value);
            }
        }
        //Ταξινομηση με βαση το χρωμα!
        private static void InsertionSort(this List<TShirt> shirts)
        {
            int j;
            TShirt temp;
            for (int i = 1; i < shirts.Count; i++)
            {
                j = i;
                while (j > 0 && shirts[j].Color < shirts[j - 1].Color)
                {
                    temp = shirts[j];
                    shirts[j] = shirts[j - 1];
                    shirts[j - 1] = temp;
                    j--;
                }
            }
        }
        private static int GetBucketNumber(TShirt value)
        {
            Color val = value.Color;
            int bucketNumber = (int)val;

            return bucketNumber;



        }
        //Φτιαχνει "Kαλαθι" με κενες Λιστες οσο το πληθος των χρωματων Tshirt !!
        private static void InitializeBuckets(List<List<TShirt>> buckets)
        {
            for (int i = 0; i < 10; i++)
            {
                List<TShirt> a = new List<TShirt>();
                buckets.Add(a);
            }
        }
        
    }

}
