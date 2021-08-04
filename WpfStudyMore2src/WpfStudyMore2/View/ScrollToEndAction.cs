using Microsoft.Xaml.Behaviors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace WpfStudy.View
{
    /// <summary>
    /// ListBoxのスクロール位置を一番したへ移動させるアクション。
    /// 型の表現を工夫すればListBoxに限定しなくても使えるかもしれない
    /// </summary>
    public class ScrollToEndAction : TriggerAction<DependencyObject>
    {
        protected override void Invoke(object parameter)
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
