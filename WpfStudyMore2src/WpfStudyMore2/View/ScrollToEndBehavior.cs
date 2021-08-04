using Microsoft.Xaml.Behaviors;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WpfStudy.View
{
    /// <summary>
    /// ItemsSouruceにバインドされているコレクションが
    /// 変化したときに、ListBoxのスクロール位置を一番下に
    /// 移動させるビヘイビア。
    /// 型の表現を工夫すればListBoxに限定しなくても使えるかもしれない
    /// </summary>
    public class ScrollToEndBehavior : Behavior<ListBox>
    {
        protected override void OnAttached()
        {
            base.OnAttached();

            var collectionObj = AssociatedObject.ItemsSource as INotifyCollectionChanged;
            if (collectionObj != null)
            {
                collectionObj.CollectionChanged += ItemsSource_CollectionChanged;
            }
        }

        protected override void OnDetaching()
        {
            var collectionObj = AssociatedObject.ItemsSource as INotifyCollectionChanged;
            if (collectionObj != null)
            {
                collectionObj.CollectionChanged -= ItemsSource_CollectionChanged;
            }

            base.OnDetaching();
        }

        private void ItemsSource_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            var listBox = AssociatedObject as ListBox;
            if (listBox == null)
            {
                return;
            }

            if (listBox.Items.Count > 0)
            {
                listBox.ScrollIntoView(listBox.Items[listBox.Items.Count - 1]);
            }
        }
    }
}
