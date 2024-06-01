using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Sharpimote
{
    /// <summary>
    /// Interaction logic for DevicesManager.xaml
    /// </summary>
    public partial class DevicesManager : Page
    {
        public DevicesManager Instance { get; set; }
        public DevicesManager()
        {
            Instance = this;
            InitializeComponent();
        }

        private void NewConn(object sender, RoutedEventArgs e)
        {
            Window authWin = new AuthAndConnect();
            authWin.ShowDialog();
        }
    }
}
