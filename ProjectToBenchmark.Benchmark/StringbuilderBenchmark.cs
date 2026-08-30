using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;
using System.Collections.Generic;
using System.Text;

namespace ProjectToBenchmark.Benchmark
{
    [KeepBenchmarkFiles(true),
     MemoryDiagnoser,
     SimpleJob(RuntimeMoniker.NetCoreApp31, -1, -1, -1, -1, null, false)]
    public class StringbuilderBenchmark
    {
        [Params(10, 100, 1000, 10_000)]
        public static int LoopStaticCounterForLoopData;

        public static string test_str = "jhjjkakjkj asdjasjkasjkkj jajiiieie hjjjjs jjjjjvnnvbb " +
            "kkdsfjsddsfosdofsdjkjlxjlk ll ldsldl lorotiiyi ollgl l" +
            "lliiiyiykfkjgjll;;km;''lkdskfksji49030" +
            "sdflksdkdsk kdsfk lfloo4959 kfdl l;df 599olfdl dfk 9fd9r999  odof fl df9994o fdo 9fd9 o4]" +
            "b hhshsh uuwuui iiahh kkakshh hgh gfgfg gasjj gjjgj";

        private static string ConcatStringToBenchmark(string unsortedString)
        {
            List<int> list = new List<int>(LoopStaticCounterForLoopData);
            for (int i = 0; i < LoopStaticCounterForLoopData; i++)
            {
                list.Add(i);
            }

            list.Sort();

            var str = "";
            // value type added for the benchmark
            foreach (var digit in list)
            {
                str += digit + " ";
            }

            return str;
        }

        private static string StringBuilderToBenchmark(string unsortedString)
        {
            List<int> listOfIntegerNumbers = new List<int>(LoopStaticCounterForLoopData);
            for (int i = 0; i < LoopStaticCounterForLoopData; i++)
            {
                listOfIntegerNumbers.Add(i);
            }

            listOfIntegerNumbers.Sort();

            StringBuilder builder = new StringBuilder(capacity: listOfIntegerNumbers.Count);
            foreach (var digit in listOfIntegerNumbers)
            {
                builder.Append(digit);
            }

            return builder.ToString();
        }

        [Benchmark]
        public void StringBuilderToBenchmark()
        {
            var resultString = StringBuilderToBenchmark(test_str);
        }

        [Benchmark(Baseline = true)]
        public void StringConcatToBenchmark()
        {
            var resultString = ConcatStringToBenchmark(test_str);
        }
    }
}