using System.Collections.Generic;
using System.Linq;

namespace Desktop
{
    public class OrderByRgbTabViewModel : BasicColorTabItemViewModel
    {
        protected override IEnumerable<ColorItem> OrderColors(IEnumerable<ColorItem> colors)
        {
            return colors
                .OrderBy(c => c.Color.Color.ScR)
                .ThenBy(c => c.Color.Color.ScG)
                .ThenBy(c => c.Color.Color.ScB);
        }
    }
}
