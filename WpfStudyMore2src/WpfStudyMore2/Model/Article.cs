using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfStudy.Model
{
    /// <summary>
    /// 記事データ
    /// </summary>
    public class Article
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Uri { get; set; }
        public string Date { get; set; }
    }
}
