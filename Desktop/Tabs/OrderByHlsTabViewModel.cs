using System.Collections.Generic;
using System.Linq;

namespace Desktop
{
    public class OrderByHlsTabViewModel : BasicColorTabItemViewModel
    {
        protected override IEnumerable<ColorItem> OrderColors(IEnumerable<ColorItem> colors)
        {
            return colors
                .OrderBy(c => new LHSVColor(c.Color.Color).Hue)
                .ThenBy(c => new LHSVColor(c.Color.Color).Luminocity)
                .ThenBy(c => new LHSVColor(c.Color.Color).Saturation);
        }
    }
}
