using System.Collections.Generic;
using System.Linq;

namespace MarathonAssessment
{
    public class BoxMover
    {
        public int GetNumberOfPiles(int boxCount, int maxCarry, int maxPileCount)
        {
            int output = 0;

            if ((boxCount >= 1 && boxCount <= 100) && (maxCarry >= 1 && maxCarry <= 5) && (maxPileCount >= 2 && maxPileCount <= 5))
            {
                if (boxCount > maxCarry)
                    return boxCount <= maxPileCount ? boxCount : BuildPiles(new List<int> { boxCount }, maxPileCount).Count;
                else
                    output = 1;
            }

            return output;
        }

        private List<int> BuildPiles(List<int> input, int maxPileBoxCount)
        {
            var pileBoxCount = input.First();

            if (pileBoxCount > maxPileBoxCount)
            {
                var split1 = pileBoxCount / 2;
                var split2 = pileBoxCount - split1;

                var partition1 = BuildPiles(new List<int> { split1 }, maxPileBoxCount);
                var partition2 = BuildPiles(new List<int> { split2 }, maxPileBoxCount);
                partition1.AddRange(partition2);
                return partition1;
            }
            else
            {
                return new List<int> { pileBoxCount };
            }
        }
    }
}
