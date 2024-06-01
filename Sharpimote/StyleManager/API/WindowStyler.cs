using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Sharpimote.StyleManager.API
{
    class WindowStyler : IWindowStyler
    {
        public virtual Control? AffectedControl { get; set; }
        public WindowStyler(Control _affectedControl)
        {
            AffectedControl = _affectedControl;
        }
        public virtual void SetStyle(Window affectedWin, ResourceDictionary styleResource)
        {
            throw new NotImplementedException();
        }
    }
}
