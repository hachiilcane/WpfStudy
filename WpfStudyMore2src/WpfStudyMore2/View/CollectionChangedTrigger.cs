﻿using Microsoft.Xaml.Behaviors;
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
    /// 変化したときのTrigger
    /// </summary>
    public class CollectionChangedTrigger : TriggerBase<ListBox>
    {
        protected override void OnAttached()
        {
            base.OnAttached();

            if (AssociatedObject.ItemsSource is INotifyCollectionChanged collectionObj)
            {
                collectionObj.CollectionChanged += ItemsSource_CollectionChanged;
            }
        }

        protected override void OnDetaching()
        {
            if (AssociatedObject.ItemsSource is INotifyCollectionChanged collectionObj)
            {
                collectionObj.CollectionChanged -= ItemsSource_CollectionChanged;
            }

            base.OnDetaching();
        }

        private void ItemsSource_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            InvokeActions(e);
        }
    }
}
