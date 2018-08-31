using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace test_08_treeview_countries
{
    public static class Behaviours
    {
        #region ExpandingBehaviour (Attached DependencyProperty)
        public static readonly DependencyProperty ExpandingBehaviourProperty =
            DependencyProperty.RegisterAttached("ExpandingBehaviour", typeof(ICommand), typeof(Behaviours),
                new PropertyMetadata(OnExpandingBehaviourChanged));

        public static void SetExpandingBehaviour(DependencyObject o, ICommand value)
        {
            o.SetValue(ExpandingBehaviourProperty, value);
        }

        public static ICommand GetExpandingBehaviour(DependencyObject o)
        {
            return (ICommand)o.GetValue(ExpandingBehaviourProperty);
        }

        private static void OnExpandingBehaviourChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            TreeViewItem treeViewItem = d as TreeViewItem;

            if (treeViewItem == null)
                return;

            ICommand iCommand = e.NewValue as ICommand;

            if (iCommand == null)
                return;

            treeViewItem.Expanded += (obj, rouEvArgs) =>
            {
                if (iCommand.CanExecute(rouEvArgs))
                {
                    iCommand.Execute(rouEvArgs);
                }

                rouEvArgs.Handled = true;
            };


        }
        #endregion
    }
}
