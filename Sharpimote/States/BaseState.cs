using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Sharpimote.States
{
    class BaseState : IState
    {
        private int current = -1;
        public string Name { get; set; }
        public Enum STATES { get; set; }
        public BaseState(string name, Enum STATES) { 
            Name = name;
            this.STATES = STATES;
        }
        public void SetState(int StateToSet)
        {
            current = StateToSet;
        }
        public bool TryGetCurrent(out int currentResult) { 
            if (current == -1)
            {
                currentResult = -1;
                return false;
            }
            currentResult = current;
            return true;
        }
    }
}
