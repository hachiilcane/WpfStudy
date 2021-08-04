using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfStudy.Common;

namespace WpfStudy.ViewModel
{
    public class ArticleViewModel : ViewModelBase
    {
        private string _title;
        private string _content;
        private DateTime _updatedDate;

        public ArticleViewModel(string title, string content, DateTime updatedDate)
        {
            _title = title;
            _content = content;
            _updatedDate = updatedDate;
        }

        public string Title
        {
            get
            {
                return _title;
            }

            set
            {
                if (_title != value)
                {
                    _title = value;
                }

                RaisePropertyChanged("Title");
            }
        }

        public string Content
        {
            get
            {
                return _content;
            }

            set
            {
                if (_content != value)
                {
                    _content = value;
                }

                RaisePropertyChanged("Content");
            }
        }

        public DateTime UpdatedDate
        {
            get
            {
                return _updatedDate;
            }

            set
            {
                if (_updatedDate != value)
                {
                    _updatedDate = value;
                }

                RaisePropertyChanged("UpdatedDate");
            }
        }
    }
}
