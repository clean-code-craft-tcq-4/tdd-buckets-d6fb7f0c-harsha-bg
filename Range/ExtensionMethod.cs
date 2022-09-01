using System;
using System.Collections.Generic;
using System.Linq;

namespace CurrenntMeasurementRange
{
    public static class ExtensionMethod
    {
        public static void PrintRanges(this List<List<int>> range)
        {
            foreach (var data in range)
            {
                Console.WriteLine("{0}-{1},{2}", data.Min(), data.Max(), data.Count);
            }
        }
    }
}
