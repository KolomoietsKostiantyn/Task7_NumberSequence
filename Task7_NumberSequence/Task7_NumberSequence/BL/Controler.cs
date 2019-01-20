using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task7_NumberSequence.Intermidiate;

namespace Task7_NumberSequence.BL
{
    class Controler
    {
        private IVisualizer _visualizer;
        private string[] _arr;
        ISequenceLogic _logic;

        public Controler(IVisualizer visualizer,string [] arr)
        {
            _visualizer = visualizer;
            _arr = arr;
        }

        public void Start()
        {
            int num;
            if (Validate(_arr, out num))
            {
                _logic = new Logic(num);
                _visualizer.ResiveAnswer(_logic.GetEnumerator());
            }
            else
            {
                _visualizer.ShowInstruction();
            }

        }

        private bool Validate(string[] arr, out int num)
        {
            num = 0;
            bool result = false;
            if (arr == null || arr.Length != 1)
            {
                return result;
            }

            if (int.TryParse(arr[0], out num))
            {
                if (num > 1)
                {
                    result = true;
                }       
            }

            return result;
        }

    }
}
