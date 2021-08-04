using System;
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

namespace WpfStudyMore1.View
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


        private void btnTrialPage_Click(object sender, RoutedEventArgs e)
        {
            NavigationService ns = NavigationService;
            ns.Navigate(new TrialPage());
        }

        private void btnTwoButtonTogglePage_Click(object sender, RoutedEventArgs e)
        {
            NavigationService ns = NavigationService;
            ns.Navigate(new TwoButtonTogglePage());
        }

        private void btnNormalCommandsPage_Click(object sender, RoutedEventArgs e)
        {
            NavigationService ns = NavigationService;
            ns.Navigate(new NormalCommandsPage());
        }

        private void btnDataBindingToSource_Click(object sender, RoutedEventArgs e)
        {
            NavigationService ns = NavigationService;
            ns.Navigate(new DataBindingToSourcePage());
        }
    }
}
