using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7_NumberSequence.Intermidiate
{
    interface IVisualizer
    {
        void ResiveAnswer(IEnumerator<int> nums);
        void ShowInstruction();
    }
}
