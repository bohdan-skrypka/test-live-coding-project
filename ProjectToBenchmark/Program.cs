using System;
using System.Collections.Generic;

namespace ProjectToBenchmark
{
    public class Program
    {
        private const int InitialSize = 100_000;

        public static void Main()
        {
            Console.WriteLine();
        }

        public static void ListOfPointsAsClass()
        {
            List<PointClass> pointClasses = new List<PointClass>(InitialSize);
            for (int i = 0; i < 10000; i++)
            {
                pointClasses.Add(new PointClass(1, 6));
            }
        }

        public static void ListOfPointsAsStruct()
        {
            List<PointStruct> pointClasses = new List<PointStruct>(InitialSize);
            for (int i = 0; i < 10000; i++)
            {
                pointClasses.Add(new PointStruct(1, 6));
            }
        }

        public static void GrowableArrayWithPointsAsStruct()
        {
            GrowableArray<PointStruct> vs = new GrowableArray<PointStruct>(InitialSize);
            for (int i = 0; i < 10000; i++)
            {
                vs.Add(new PointStruct(1, 6));
            }
        }

        public static void GrowableArrayWithPointsAsClass()
        {
            GrowableArray<PointClass> vs = new GrowableArray<PointClass>(InitialSize);
            for (int i = 0; i < 10000; i++)
            {
                vs.Add(new PointClass(1, 6));
            }
        }
    }

    public class PointClass
    {
        public int X { get; set; }
        public int Y { get; set; }

        public PointClass(int x, int y) { X = x; Y = y; }
    }

    public struct PointStruct
    {
        public int X { get; set; }
        public int Y { get; set; }

        public PointStruct(int x, int y) { X = x; Y = y; }
    }
}
