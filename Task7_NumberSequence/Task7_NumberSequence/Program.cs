using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task7_NumberSequence.BL;
using Task7_NumberSequence.Intermidiate;
using Task7_NumberSequence.UI;

namespace Task7_NumberSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            IVisualizer visual = new ConsoleUI();
            Controler controler = new Controler(visual, args);
            controler.Start();


        }
    }
}
