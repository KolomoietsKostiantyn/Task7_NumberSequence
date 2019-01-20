using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task7_NumberSequence.Intermidiate;

namespace Task7_NumberSequence.BL
{
    class Logic : ISequenceLogic
    {
 
        public int Counts
        {
            get;
            private set;
        }

        public Logic(int num)
        {
            Counts = (int)Math.Sqrt(num);
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 1; i < Counts; i++)
            {
                yield return i;
            }
        }
    }
}
