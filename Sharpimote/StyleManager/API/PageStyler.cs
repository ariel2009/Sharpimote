using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Sharpimote.StyleManager.API
{
    class PageStyler : WindowStyler, IPageStyler
    {
        protected virtual Control? AffectedControl { get => AffectedControl; set => AffectedControl = value; }
        public PageStyler(Control? affectedControl) : base(affectedControl)
        {
            AffectedControl = affectedControl;
        }

        public virtual void SetStyle(Page affectedPage, ResourceDictionary styleResource)
        {
            throw new NotImplementedException();
        }
    }
}
