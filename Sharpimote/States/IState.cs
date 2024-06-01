using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sharpimote.States
{
    interface IState
    {
        public abstract void SetState(int StateToSet);
    }
}
