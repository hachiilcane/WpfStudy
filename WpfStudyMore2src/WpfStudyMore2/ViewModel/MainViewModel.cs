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
        private NewsCrawler _crawler = new NewsCrawler();

        public ObservableCollection<ArticleViewModel> Articles { get; } = new ObservableCollection<ArticleViewModel>();

        public RelayCommand NewsSubscriptionCommand { get; }

        public MainViewModel()
        {
            NewsSubscriptionCommand = new RelayCommand(
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

        private void Crawler_Updated(object sender, NewsUpdatedEventArgs e)
        {
            var latestNews = e.Articles;

            Application.Current?.Dispatcher.Invoke(new Action(() =>
            {
                latestNews.ForEach(
                    n =>
                    {
                        Articles.Add(
                            new ArticleViewModel(n.Title, n.Content, DateTime.Parse(n.Date)));
                    });
            }));
        }
    }
}
