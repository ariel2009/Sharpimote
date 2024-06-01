using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace SharpimoteClient.Transitions
{
    internal interface IPageAnimator 
    {
        public abstract void NavigateWithSlideAnimation(Frame frame, Page page);
    }
}
