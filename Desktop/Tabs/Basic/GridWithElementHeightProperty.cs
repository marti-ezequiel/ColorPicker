using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Desktop.Tabs.Basic
{
    public class GridWithElementHeightProperty : Grid
    {
        public Double ElementsHeight
        {
            get { return (Double)GetValue(ElementsHeightProperty); }
            set { SetValue(ElementsHeightProperty, value); }
        }
        
        public static readonly DependencyProperty ElementsHeightProperty =
            DependencyProperty.Register("ElementsHeight", typeof(Double), typeof(GridWithElementHeightProperty), new PropertyMetadata(1d));

        protected override void OnRenderSizeChanged(SizeChangedInfo sizeInfo)
        {
            this.ElementsHeight = this.ActualHeight / (this.Children.Count < 1 ? 1 : this.Children.Count);
        }
    }
}
