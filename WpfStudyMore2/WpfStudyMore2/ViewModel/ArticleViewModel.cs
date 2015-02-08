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
        private string title;
        private string content;
        private DateTime updatedDate;

        public ArticleViewModel(string title, string content, DateTime updatedDate)
        {
            this.title = title;
            this.content = content;
            this.updatedDate = updatedDate;
        }

        public string Title
        {
            get
            {
                return this.title;
            }

            set
            {
                if (this.title != value)
                {
                    this.title = value;
                }

                this.RaisePropertyChanged("Title");
            }
        }

        public string Content
        {
            get
            {
                return this.content;
            }

            set
            {
                if (this.content != value)
                {
                    this.content = value;
                }

                this.RaisePropertyChanged("Content");
            }
        }

        public DateTime UpdatedDate
        {
            get
            {
                return this.updatedDate;
            }

            set
            {
                if (this.updatedDate != value)
                {
                    this.updatedDate = value;
                }

                this.RaisePropertyChanged("UpdatedDate");
            }
        }
    }
}
