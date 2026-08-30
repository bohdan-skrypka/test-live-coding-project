using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Running;
using System.Collections.Generic;
using System.Text;

namespace ProjectToBenchmark.Benchmark.Run
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
    public class BenchmarkToRun
    {
        static void Main()
        {
            //BenchmarkRunner.Run<StringbuilderBenchmark>();
            //BenchmarkRunner.Run<PostfixToBenchmark>();
            //BenchmarkRunner.Run<AlgorithmToBenchmark>();
        }
    }
}
