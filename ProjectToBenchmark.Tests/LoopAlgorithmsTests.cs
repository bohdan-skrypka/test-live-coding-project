using System;
using Xunit;
using ProjectToBenchmark;
using BenchmarkDotNet.Attributes;
using ProjectToBenchmark.ToBenchmark.Algorithms.Loop;

namespace ProjectToBenchmark.Tests
{
    [MemoryDiagnoser]
    public class LoopAlgorithmsTests
    {
        [Fact]
        public void Test1()
        {
            LoopAlgorithmsBenchmark loopAlgorithmsBenchmark = new LoopAlgorithmsBenchmark();

            loopAlgorithmsBenchmark.ForLoopPrefixTobenchmark();
            loopAlgorithmsBenchmark.ForLoopPostfixBenchmark();
        }
    }
}
