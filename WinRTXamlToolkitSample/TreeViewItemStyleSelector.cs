using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace WinRTXamlToolkitSample
{
    public class TreeViewItemStyleSelector:StyleSelector
    {
        public TreeViewItemStyleSelector()
        {
            var abc= 123;
        }
        public Style ResourceStyle { get; set; }

        public Style ClassroomStyle { get; set; }

        protected override Style SelectStyleCore(object item, DependencyObject container)
        {
            return base.SelectStyleCore(item, container);
        }
        
    }
}
