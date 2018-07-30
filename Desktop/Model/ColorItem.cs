using System;
using System.Windows.Media;

namespace Desktop
{
    public class ColorItem
    {
        public ColorItem(String name, SolidColorBrush color)
        {
            this.Name = name;
            this.Color = color;
        }

        public String Name { get; set; }

        public SolidColorBrush Color { get; set; }
    }
}
