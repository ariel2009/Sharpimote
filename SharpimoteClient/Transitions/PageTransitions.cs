using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace SharpimoteClient.Transitions
{
    internal class PageTransitions
    {
        public static void MakeForwardTrasition(Window parentWin, Page navigateTo, Frame rendererFrame)
        {
            PageAnimation slideAnim = new PageAnimation();
            slideAnim.NavigateWithSlideAnimation(rendererFrame, navigateTo);
        }
    }
}
