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
        private ObservableCollection<ArticleViewModel> articles = new ObservableCollection<ArticleViewModel>();
        private RelayCommand newsSubscriptionCommand;
        private NewsCrawler crawler = new NewsCrawler();

        public ObservableCollection<ArticleViewModel> Articles
        {
            get
            {
                return this.articles;
            }
        }

        public RelayCommand NewsSubscriptionCommand
        {
            get
            {
                if (this.newsSubscriptionCommand == null)
                {
                    this.newsSubscriptionCommand = new RelayCommand(
                        o =>    // ExecuteCommand
                        {
                            bool isChecked = (bool)o;
                            if (isChecked)
                            {
                                this.crawler.Updated += Crawler_Updated;
                                this.crawler.Start();
                            }
                            else
                            {
                                this.crawler.Updated -= Crawler_Updated;
                                this.crawler.Stop();
                            }
                        });
                }

                return this.newsSubscriptionCommand;
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
                                this.Articles.Add(
                                    new ArticleViewModel(n.Title, n.Content, DateTime.Parse(n.Date)));
                            });
                    }));
            }
        }
    }
}
