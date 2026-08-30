using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;

namespace ProjectToBenchmark.ToBenchmark.Algorithms.Loop
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
    public class LoopAlgorithmsBenchmark
    {
        [Params(100, 1_00, 10_000, 100_000)]
        public int LoopSize { get; set; }

        [Benchmark(Baseline = true)]
        public void ForLoopPostfixBenchmark()
        {
            int count = 0;
            for (int i = 0; i < LoopSize; i++)
            {
                ++count;
            }
        }

        [Benchmark]
        public void ForLoopPrefixTobenchmark()
        {
            int count = 0;
            for (int i = 0; i < LoopSize; ++i)
            {
                ++count;
            }
        }
    }
}