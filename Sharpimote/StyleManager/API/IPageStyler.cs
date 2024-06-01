using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;

namespace Sharpimote.StyleManager.API
{
    internal interface IPageStyler
    {
        public static Control? control { get; set; }
        public abstract void SetStyle(Page affectedPage, ResourceDictionary styleResource);
    }
}
