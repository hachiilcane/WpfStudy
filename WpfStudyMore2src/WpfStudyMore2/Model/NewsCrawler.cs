using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace WpfStudy.Model
{
    /// <summary>
    /// ニュースをかき集めてくるモデルクラス。
    /// 集めてきたらイベントで通知する
    /// </summary>
    public class NewsCrawler
    {
        private Timer _crawlTimer;
        public event EventHandler<NewsUpdatedEventArgs> Updated;

        public void Start()
        {
            if (_crawlTimer == null)
            {
                _crawlTimer = new Timer(2000);
                _crawlTimer.Elapsed += CrawlTimer_Elapsed;
                _crawlTimer.Enabled = true;
            }
        }

        public void Stop()
        {
            if (_crawlTimer != null)
            {
                _crawlTimer.Enabled = false;
                _crawlTimer.Elapsed -= CrawlTimer_Elapsed;
                _crawlTimer.Dispose();
                _crawlTimer = null;
            }
        }

        private void CrawlTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            // null 条件演算子（?を使った書き方）を使うと、nullチェックが楽に書けます。
            Updated?.Invoke(this, new NewsUpdatedEventArgs(GetNews()));
        }

        private bool _first = true;

        private List<Article> GetNews()
        {
            List<Article> latestNews = new List<Article>();
            if (_first)
            {
                _first = false;
                latestNews.Add(new Article() { Title = "とらさんが誕生日を迎えました", Content = "", Uri = "", Date = "2015-02-07 7:23:09" });
                latestNews.Add(new Article() { Title = "ぱんださんは上野で休憩中です", Content = "", Uri = "", Date = "2015-02-08 9:01:45" });
                latestNews.Add(new Article() { Title = "ひつじさん今年は全国で人気急上昇", Content = "", Uri = "", Date = "2015-02-08 9:02:32" });
                latestNews.Add(new Article() { Title = "うさぎさんの長い耳の秘密とは", Content = "", Uri = "", Date = "2015-02-09 16:57:48" });
            }
            else
            {
                latestNews.Add(new Article() { Title = "となかいさん赤鼻の手入れに余念がない", Content = "", Uri = "", Date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") });
                latestNews.Add(new Article() { Title = "うまさん日本走ろう会の発足を宣言", Content = "", Uri = "", Date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") });
            }

            return latestNews;
        }
    }
}
