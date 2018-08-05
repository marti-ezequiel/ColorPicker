using System;
using System.Collections.Generic;
using System.Linq;

namespace Desktop
{
    public class OrderByStepsTabViewModel : BasicColorTabItemViewModel
    {
        private readonly Int32 steps = 7;

        protected override IEnumerable<ColorItem> OrderColors(IEnumerable<ColorItem> colors)
        {
            return colors
                .OrderBy(c => new LHSVColor(c.Color.Color).Saturation != 0)
                .ThenBy(c => Math.Floor(new LHSVColor(c.Color.Color).Hue * this.steps))
                .ThenBy(c => new LHSVColor(c.Color.Color).Luminocity)
                .ThenBy(c => Math.Floor(new LHSVColor(c.Color.Color).Value * this.steps));
        }
    }
}
