using System;
using Xunit;
using ProjectToBenchmark;
using BenchmarkDotNet.Attributes;
using ProjectToBenchmark.ToBenchmark.Algorithms.String;
using ProjectToBenchmark.ToBenchmark.Algorithms.Collections;

namespace ProjectToBenchmark.Tests
{
    public class CollectionsAlgorithmsTests
    {
        [Fact]
        public void CollectionsTest()
        {
            CollectionsBenchmark.ListOfPointsAsClass();
            CollectionsBenchmark.ListOfPointsAsStruct();

            CollectionsBenchmark.GrowableArrayWithPointsAsClass();
            CollectionsBenchmark.GrowableArrayWithPointsAsStruct();
        }
    }
}
