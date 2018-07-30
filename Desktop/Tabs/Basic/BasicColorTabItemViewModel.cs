using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Media;

namespace Desktop
{
    public abstract class BasicColorTabItemViewModel : ViewModel
    {
        public IEnumerable<ColorItem> Colors { get; protected set; }

        public ColorItem SelectedColor { get; set; }

        public BasicColorTabItemViewModel()
        {
            this.InitializateColorList();
        }

        protected abstract IEnumerable<ColorItem> OrderColors(IEnumerable<ColorItem> colors);

        private void InitializateColorList()
        {
            var colors = typeof(Brushes)
                .GetProperties()
                .Select(prop => new ColorItem(
                    prop.Name,
                    (SolidColorBrush)prop.GetValue(null, null)));

            this.Colors = this.OrderColors(colors);

            this.RaisePropertyChange("Colors");
        }
    }
}
