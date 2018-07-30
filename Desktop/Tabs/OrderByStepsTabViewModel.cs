using System.Collections.Generic;
using System.Linq;

namespace Desktop
{
    public class OrderByStepsTabViewModel : BasicColorTabItemViewModel
    {
        protected override IEnumerable<ColorItem> OrderColors(IEnumerable<ColorItem> colors)
        {
            return colors
                .OrderBy(c => new LHSVColor(c.Color.Color).Hue * 8)
                .ThenBy(c => new LHSVColor(c.Color.Color).Luminocity * 8)
                .ThenBy(c => new LHSVColor(c.Color.Color).Saturation * 8);
        }
    }
}
