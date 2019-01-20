using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7_NumberSequence.BL
{
    interface ISequenceLogic
    {
        IEnumerator<int> GetEnumerator();
    }
}
