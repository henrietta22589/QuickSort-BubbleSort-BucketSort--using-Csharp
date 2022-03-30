using ConsoleApp.ShortingAlgorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyDatabase db = new MyDatabase();
            var shirts = db.TShirts;



            // shirts.BubbleOrderBySize();
            //shirts.BubbleOrderBySizeColorFabric();
            //QuickShort.quickSortOrderByColor(shirts, 0, shirts.Count - 1);

            //shirts.quickSortOrderByColor(0, shirts.Count - 1);
            //shirts.quickSortOrderBySize(0, shirts.Count - 1);
            //var shirts = db.TShirts.OrderBy(x=>x.Fabric).ThenBy(x=>x.Color).ThenBy(x=>x.Size);
            //////shirts.BubbleOrderByColor();
            //shirts.BurbbleOrderBySizeColorFabric();


            //shirts.BucketSortByColor();

            foreach (var shirt in shirts)
            {
                shirt.Output();
            }
        }
    }
}
