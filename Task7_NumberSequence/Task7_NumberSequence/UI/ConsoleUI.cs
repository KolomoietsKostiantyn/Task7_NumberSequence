using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task7_NumberSequence.Intermidiate;

namespace Task7_NumberSequence.UI
{
    class ConsoleUI : IVisualizer
    {
        public void ShowInstruction()
        {
            Console.WriteLine("Enter the number and get a series of natural" +
                    " numbers separated by commas, the square of which is less " +
                    "than the given n.");
            Console.ReadKey();
        }

        public void ResiveAnswer(IEnumerator<int> nums)
        {
            bool flag = true;
            while (nums.MoveNext())
            {
                if (flag)
                {
                    Console.Write(nums.Current);
                }
                else
                {
                    Console.Write(", {0}", nums.Current);
                }
                flag = false;
            }

            Console.ReadKey();
        }
    }
}
