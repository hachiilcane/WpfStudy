using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Interactivity;

namespace WpfStudy.View
{
    /// <summary>
    /// ItemsSouruceにバインドされているコレクションが
    /// 変化したときのTrigger
    /// </summary>
    public class CollectionChangedTrigger : TriggerBase<ListBox>
    {
        protected override void OnAttached()
        {
            base.OnAttached();

            var collectionObj = this.AssociatedObject.ItemsSource as INotifyCollectionChanged;
            if (collectionObj != null)
            {
                collectionObj.CollectionChanged += ItemsSource_CollectionChanged;
            }
        }

        protected override void OnDetaching()
        {
            var collectionObj = this.AssociatedObject.ItemsSource as INotifyCollectionChanged;
            if (collectionObj != null)
            {
                collectionObj.CollectionChanged -= ItemsSource_CollectionChanged;
            }

            base.OnDetaching();
        }

        private void ItemsSource_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            this.InvokeActions(e);
        }
    }
}
