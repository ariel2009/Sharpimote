using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using Sharpimote.StyleManager.API;

namespace Sharpimote.Style
{
    internal class TextBoxStyler : PageStyler
    {
        protected override Control? AffectedControl { get; set; }
        public TextBoxStyler(TextBox? _affectedTextBox) : base(_affectedTextBox)
        {
            AffectedControl = _affectedTextBox; 
        }
        public override void SetStyle(Page affectedPage, ResourceDictionary styleResource)
        {
            base.SetStyle(affectedPage, styleResource);
        }
        public override void SetStyle(Window affectedWin, ResourceDictionary styleResource)
        {
            base.SetStyle(affectedWin, styleResource);
        }
    }
}
