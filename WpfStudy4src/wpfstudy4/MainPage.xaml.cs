﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfStudy4
{
    /// <summary>
    /// MainPage.xaml の相互作用ロジック
    /// </summary>
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnSimpleSamplePage_Click(object sender, RoutedEventArgs e)
        {
            NavigationService ns = this.NavigationService;
            ns.Navigate(new SimpleSamplePage());
        }

        private void btnTrialPage_Click(object sender, RoutedEventArgs e)
        {
            NavigationService ns = this.NavigationService;
            ns.Navigate(new TrialPage());
        }

        private void btnVisualBrushSample_Click(object sender, RoutedEventArgs e)
        {
            NavigationService ns = this.NavigationService;
            ns.Navigate(new VisualBrushPage());
        }
    }
}
