using System.Collections.Generic;
using System.Linq;

namespace Desktop
{
    public class OrderByLuminosityTabViewModel : BasicColorTabItemViewModel
    {
        protected override IEnumerable<ColorItem> OrderColors(IEnumerable<ColorItem> colors)
        {
            return colors
                .OrderBy(c => new LHSVColor(c.Color.Color).Luminocity);
        }
    }
}
