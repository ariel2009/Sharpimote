using Sharpimote;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Xps.Serialization;

namespace Sharpimote
{
    /// <summary>
    /// Interaction logic for AuthAndConnect.xaml
    /// </summary>
    public partial class AuthAndConnect : Window
    {
        private string initialHelpTextCode;
        public AuthAndConnect()
        {
            InitializeComponent();
            initialHelpTextCode = CodeField.Text;
        }

        private void CodeField_GotFocus(object sender, RoutedEventArgs e)
        {
            if (CodeField.Text == initialHelpTextCode)
            {
                CodeField.Text = string.Empty;
                CodeField.Foreground = ColorInHex("#1F2937");
            }
        }

        private void CodeField_LostFocus(object sender, RoutedEventArgs e)
        {
            if (CodeField.Text == string.Empty)
            {
                CodeField.Foreground = ColorInHex("#B2B2B2");
                CodeField.Text = initialHelpTextCode;
            }
        }

        private void passwordField_LostFocus(object sender, RoutedEventArgs e)
        {
            if(passwordField.Password == string.Empty)
            {
                passwordField.Visibility = Visibility.Collapsed;
                HelpTextBox.Visibility = Visibility.Visible;
            }
        }

        private void HelpTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            HelpTextBox.Visibility = Visibility.Collapsed;
            passwordField.Visibility = Visibility.Visible;
        }
        private Brush ColorInHex(string hexColor)
        {
            BrushConverter bc = new BrushConverter();
            return (Brush)bc.ConvertFrom(hexColor);
        }
    }
}
