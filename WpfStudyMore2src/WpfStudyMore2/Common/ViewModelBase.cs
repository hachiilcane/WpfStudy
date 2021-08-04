using System.Collections.Generic;
using System.ComponentModel;

namespace WpfStudy.Common
{
    public class ViewModelBase : INotifyPropertyChanged, IDataErrorInfo
    {
        private Dictionary<string, string> errors = new Dictionary<string, string>();

        public event PropertyChangedEventHandler PropertyChanged;

        public string Error
        {
            get { throw new System.NotImplementedException(); }
        }

        public bool HasError
        {
            get
            {
                return this.errors.Count != 0;
            }
        }

        public string this[string columnName]
        {
            get
            {
                if (this.errors.ContainsKey(columnName))
                {
                    return this.errors[columnName];
                }

                return null;
            }
        }

        protected void SetError(string propertyName, string errorMessage)
        {
            this.errors[propertyName] = errorMessage;
            this.RaisePropertyChanged("HasError");
        }

        protected void ClearError(string propertyName)
        {
            if (this.errors.ContainsKey(propertyName))
            {
                this.errors.Remove(propertyName);
                this.RaisePropertyChanged("HasError");
            }
        }

        protected void ClearErrors()
        {
            this.errors.Clear();
            this.RaisePropertyChanged("HasError");
        }

        protected virtual void RaisePropertyChanged(string propertyName)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
