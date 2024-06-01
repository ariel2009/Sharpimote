using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Sharpimote.StyleManager.API
{
    interface IWindowStyler
    {
        public static Control? control { get; set; }
        public abstract void SetStyle(Window affectedWin, ResourceDictionary styleResource);
    }
}
