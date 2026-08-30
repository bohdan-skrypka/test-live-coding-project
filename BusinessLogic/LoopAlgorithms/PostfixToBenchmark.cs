using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;

namespace BusinessLogic.LoopAlgorithms
{
    public class PostfixToBenchmark
    {
        public int Length { get; set; }

        public void ClassTobenchmark()
        {
            int count = 0;
            for (int i = 0; i < Length; i++)
            {
                ++count;
            }
        }

        public void StructTobenchmark()
        {
            int count = 0;
            for (int i = 0; i < Length; ++i)
            {
                ++count;
            }
        }
    }
}