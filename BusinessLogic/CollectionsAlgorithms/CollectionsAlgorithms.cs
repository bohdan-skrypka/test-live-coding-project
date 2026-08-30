using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;
using BusinessLogic.Models.Entities;
using System.Collections.Generic;

namespace BusinessLogic.CollectionsAlgorithms
{
    public class CollectionsAlgorithms
    {
        private const int InitialSize = 100_000;

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
}