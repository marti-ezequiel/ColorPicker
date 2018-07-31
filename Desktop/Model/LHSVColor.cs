using System;
using System.Windows.Media;

public struct LHSVColor
{
    public Double Hue;
    public Double Saturation;
    public Double Value;
    public Double Luminocity;

    public LHSVColor(Color colorRgb)
    {
        var color = System.Drawing.Color.FromArgb(colorRgb.R, colorRgb.G, colorRgb.B);

        int max = Math.Max(color.R, Math.Max(color.G, color.B));
        int min = Math.Min(color.R, Math.Min(color.G, color.B));

        this.Hue = Math.Round(color.GetHue() / 300d, 2);
        this.Saturation = ((max == 0) ? 0 : 1d - (1d * min / max));
        this.Saturation = Math.Round(this.Saturation, 2);
        this.Value = Math.Round(((max / 255d)), 2);
        this.Luminocity = Math.Sqrt(
            color.R * .241 +
            color.G * .691 +
            color.B * .068
            );
    }
}