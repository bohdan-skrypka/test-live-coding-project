using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Running;
using ProjectToBenchmark.ToBenchmark.Algorithms.Collections;
using ProjectToBenchmark.ToBenchmark.Algorithms.Loop;
using ProjectToBenchmark.ToBenchmark.Algorithms.String;
using System.Collections.Generic;
using System.Text;

namespace ProjectToBenchmark.Benchmark
{
    //[MemoryDiagnoser]
    ////[SimpleJob(runtimeMoniker: RuntimeMoniker.Net461)]
    ////[SimpleJob(runtimeMoniker: RuntimeMoniker.Net462)]
    ////[SimpleJob(runtimeMoniker: RuntimeMoniker.Net47)]
    ////[SimpleJob(runtimeMoniker: RuntimeMoniker.Net471)]
    ////[SimpleJob(runtimeMoniker: RuntimeMoniker.Net472)]
    ////[SimpleJob(runtimeMoniker: RuntimeMoniker.Net48)]
    ////[SimpleJob(runtimeMoniker: RuntimeMoniker.NetCoreApp20)]
    ////[SimpleJob(runtimeMoniker: RuntimeMoniker.NetCoreApp21)]
    ////[SimpleJob(runtimeMoniker: RuntimeMoniker.NetCoreApp22)]
    ////[SimpleJob(runtimeMoniker: RuntimeMoniker.NetCoreApp30)]
    ////[SimpleJob(runtimeMoniker: RuntimeMoniker.NetCoreApp31)]
    //[SimpleJob(runtimeMoniker: RuntimeMoniker.NetCoreApp31)]
    //[KeepBenchmarkFiles]
    public class BenchmarkEntryPoint
    {
        static void Main()
        {
            BenchmarkRunner.Run<StringsBenchmark>();
            // BenchmarkRunner.Run<LoopAlgorithmsBenchmark>();
            // BenchmarkRunner.Run<CollectionsBenchmark>();
        }
    }
}
