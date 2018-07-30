using System.Collections.Generic;
using System.Linq;

namespace Desktop
{
    public class OrderByHsvTabViewModel : BasicColorTabItemViewModel
    {
        protected override IEnumerable<ColorItem> OrderColors(IEnumerable<ColorItem> colors)
        {
            return colors
                .OrderBy(c => new LHSVColor(c.Color.Color).Hue)
                .ThenBy(c => new LHSVColor(c.Color.Color).Saturation)
                .ThenBy(c => new LHSVColor(c.Color.Color).Luminocity);
        }
    }
}
