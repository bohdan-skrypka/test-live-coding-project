using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;
using System.Collections.Generic;
using System.Text;

namespace ProjectToBenchmark.ToBenchmark.Algorithms.String
{
    [KeepBenchmarkFiles(true),
     MemoryDiagnoser,
     SimpleJob(RuntimeMoniker.NetCoreApp31, -1, -1, -1, -1, null, false)]
    public class StringsBenchmark
    {
        [Params(10, 100, 1000, 10_000)]
        public static int StaticCounterForLoopSize;

        public static string test_str = "jhjjkakjkj asdjasjkasjkkj jajiiieie hjjjjs jjjjjvnnvbb " +
            "kkdsfjsddsfosdofsdjkjlxjlk ll ldsldl lorotiiyi ollgl l" +
            "lliiiyiykfkjgjll;;km;''lkdskfksji49030" +
            "sdflksdkdsk kdsfk lfloo4959 kfdl l;df 599olfdl dfk 9fd9r999  odof fl df9994o fdo 9fd9 o4]" +
            "b hhshsh uuwuui iiahh kkakshh hgh gfgfg gasjj gjjgj";

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

        #region Private Methods

        /// <summary>
        /// This method benchmarks the performance of using string concatenation to the general string-line
        /// </summary>
        /// <param name="unsortedString"></param>
        /// <returns></returns>
        private static string ConcatStringToBenchmark(string unsortedString)
        {
            List<int> list = new List<int>(StaticCounterForLoopSize);
            for (int i = 0; i < StaticCounterForLoopSize; i++)
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

        /// <summary>
        /// This method benchmarks the performance of using StringBuilder with list of integers into a single string.
        /// Finally, it returns the resulting string.
        /// </summary>
        /// <param name="unsortedString"></param>
        /// <returns></returns>
        private static string StringBuilderToBenchmark(string unsortedString)
        {
            List<int> listOfIntegerNumbers = new List<int>(StaticCounterForLoopSize);
            for (int i = 0; i < StaticCounterForLoopSize; i++)
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

        #endregion

    }
}