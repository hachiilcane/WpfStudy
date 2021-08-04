using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfStudy.Model
{
    /// <summary>
    /// ニュースが更新されたイベントの引数。
    /// 新しく取得できたニュースだけが含まれている
    /// </summary>
    public class NewsUpdatedEventArgs : EventArgs
    {
        public NewsUpdatedEventArgs(List<Article> articles)
        {
            Articles = articles;
        }

        public List<Article> Articles { get; private set; }
    }
}
