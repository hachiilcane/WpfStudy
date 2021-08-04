using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WpfStudy.Common;
using WpfStudy.Model;

namespace WpfStudy.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        private RelayCommand _newsSubscriptionCommand;
        private NewsCrawler _crawler = new NewsCrawler();

        public ObservableCollection<ArticleViewModel> Articles { get; } = new ObservableCollection<ArticleViewModel>();

        public RelayCommand NewsSubscriptionCommand
        {
            get
            {
                if (_newsSubscriptionCommand == null)
                {
                    _newsSubscriptionCommand = new RelayCommand(
                        isChecked =>    // ExecuteCommand
                        {
                            if ((bool)isChecked)
                            {
                                _crawler.Updated += Crawler_Updated;
                                _crawler.Start();
                            }
                            else
                            {
                                _crawler.Updated -= Crawler_Updated;
                                _crawler.Stop();
                            }
                        });
                }

                return _newsSubscriptionCommand;
            }
        }

        private void Crawler_Updated(object sender, NewsUpdatedEventArgs e)
        {
            var news = e.Articles;
            if (Application.Current != null)
            {
                Application.Current.Dispatcher.Invoke(new Action(() =>
                {
                    news.ForEach(
                        n =>
                        {
                            Articles.Add(
                                new ArticleViewModel(n.Title, n.Content, DateTime.Parse(n.Date)));
                        });
                }));
            }
        }
    }
}
