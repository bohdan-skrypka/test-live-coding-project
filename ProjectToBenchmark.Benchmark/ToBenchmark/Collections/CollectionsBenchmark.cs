using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;
using ProjectToBenchmark.Benchmark.Models;
using System.Collections.Generic;

namespace ProjectToBenchmark.ToBenchmark.Algorithms.Collections
{
    [MemoryDiagnoser]
    //[SimpleJob(runtimeMoniker: RuntimeMoniker.Net461)]
    //[SimpleJob(runtimeMoniker: RuntimeMoniker.Net462)]
    //[SimpleJob(runtimeMoniker: RuntimeMoniker.Net47)]
    //[SimpleJob(runtimeMoniker: RuntimeMoniker.Net471)]
    //[SimpleJob(runtimeMoniker: RuntimeMoniker.Net472)]
    //[SimpleJob(runtimeMoniker: RuntimeMoniker.Net48)]
    //[SimpleJob(runtimeMoniker: RuntimeMoniker.NetCoreApp20)]
    //[SimpleJob(runtimeMoniker: RuntimeMoniker.NetCoreApp21)]
    //[SimpleJob(runtimeMoniker: RuntimeMoniker.NetCoreApp22)]
    //[SimpleJob(runtimeMoniker: RuntimeMoniker.NetCoreApp30)]
    //[SimpleJob(runtimeMoniker: RuntimeMoniker.NetCoreApp31)]
    [SimpleJob(runtimeMoniker: RuntimeMoniker.NetCoreApp31)]
    [KeepBenchmarkFiles]
    public class CollectionsBenchmark
    {
        private const int InitialCollectionSize = 100_000;

        [Benchmark]
        public static void ListOfPointsAsClass()
        {
            List<PointClass> pointClasses = new List<PointClass>(InitialCollectionSize);
            for (int i = 0; i < 10000; i++)
            {
                pointClasses.Add(new PointClass(1, 6));
            }
        }

        [Benchmark]
        public static void ListOfPointsAsStruct()
        {
            List<PointStruct> pointClasses = new List<PointStruct>(InitialCollectionSize);
            for (int i = 0; i < 10000; i++)
            {
                pointClasses.Add(new PointStruct(1, 6));
            }
        }

        [Benchmark]
        public static void GrowableArrayWithPointsAsStruct()
        {
            GrowableArray<PointStruct> vs = new GrowableArray<PointStruct>(InitialCollectionSize);
            for (int i = 0; i < 10000; i++)
            {
                vs.Add(new PointStruct(1, 6));
            }
        }

        [Benchmark]
        public static void GrowableArrayWithPointsAsClass()
        {
            GrowableArray<PointClass> vs = new GrowableArray<PointClass>(InitialCollectionSize);
            for (int i = 0; i < 10000; i++)
            {
                vs.Add(new PointClass(1, 6));
            }
        }
    }
}