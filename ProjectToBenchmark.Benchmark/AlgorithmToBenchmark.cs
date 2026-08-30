using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;

namespace ProjectToBenchmark.Benchmark
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
    public class AlgorithmToBenchmark
    {
        [Benchmark]
        public void ListOfPointsAsClassTobenchmark()
        {
            Program.ListOfPointsAsClass();
        }

        [Benchmark]
        public void ListOfPointAsStructTobenchmark()
        {
            Program.ListOfPointsAsStruct();
        }

        [Benchmark]
        public void GrowableArrayOfClassPointsTobenchmark()
        {
            Program.GrowableArrayWithPointsAsClass();
        }

        [Benchmark]
        public void GrowableArrayOfStructPointsTobenchmark()
        {
            Program.GrowableArrayWithPointsAsStruct();
        }
    }
}