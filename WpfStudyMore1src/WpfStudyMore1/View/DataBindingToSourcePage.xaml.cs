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
using WpfStudyMore1.ViewModel;

namespace WpfStudyMore1.View
{
    /// <summary>
    /// DataBindingToSourcePage.xaml の相互作用ロジック
    /// </summary>
    public partial class DataBindingToSourcePage : Page
    {
        public DataBindingToSourcePage()
        {
            InitializeComponent();

            DataContext = new AnimalPageViewModel();
        }
    }
}
