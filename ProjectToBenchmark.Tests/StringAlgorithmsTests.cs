using System;
using Xunit;
using ProjectToBenchmark;
using BenchmarkDotNet.Attributes;
using ProjectToBenchmark.ToBenchmark.Algorithms.String;

namespace ProjectToBenchmark.Tests
{
    [MemoryDiagnoser]
    public class StringAlgorithmsTests
    {
        [Fact]
        public void Test1()
        {
            StringsBenchmark stringsBenchmark = new StringsBenchmark();

            stringsBenchmark.StringBuilderToBenchmark();
            stringsBenchmark.StringConcatToBenchmark();
        }
    }
}
