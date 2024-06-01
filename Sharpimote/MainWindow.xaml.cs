﻿using Sharpimote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Automation.Provider;
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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static MainWindow Instance {get; set;}
        public MainWindow()
        {
            InitializeComponent();
            Instance = this;
            MainContent.NavigationUIVisibility = NavigationUIVisibility.Hidden;
            MainContent.Content = new Welcome();
        }
    }
}
