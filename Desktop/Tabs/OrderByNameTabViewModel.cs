using System.Collections.Generic;
using System.Linq;

namespace Desktop
{
    public class OrderByNameTabViewModel : BasicColorTabItemViewModel
    {
        protected override IEnumerable<ColorItem> OrderColors(IEnumerable<ColorItem> colors)
        {
            return colors.OrderBy(c => c.Name);
        }
    }
}