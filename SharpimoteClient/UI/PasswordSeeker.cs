using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;

namespace SharpimoteClient.Style
{
    internal class PasswordSeeker
    {
        public TextBlock ShowenPassBox { get; set; }
        public PasswordBox HiddenPassBox { get; set; }
        public PasswordSeeker(TextBlock showenPassBox, PasswordBox hiddenPassBox)
        {
            ShowenPassBox = showenPassBox;
            HiddenPassBox = hiddenPassBox;
        }
        public void Seek()
        {
            HiddenPassBox.Visibility = Visibility.Collapsed;
            ShowenPassBox.Visibility = Visibility.Visible;
        }
        public void Hide()
        {
            ShowenPassBox.Visibility = Visibility.Collapsed;
            HiddenPassBox.Visibility = Visibility.Visible;
        }
    }
}
