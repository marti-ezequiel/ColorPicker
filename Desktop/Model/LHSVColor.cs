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

        Double max = Math.Max(color.R, Math.Max(color.G, color.B));
        Double min = Math.Min(color.R, Math.Min(color.G, color.B));

        this.Hue = color.GetHue() / 300d;
        this.Luminocity = (max + min) / 2d / 255d;
        this.Saturation = max == min ? 0 : (max - min) / (1d - Math.Abs(this.Luminocity * 2d - 1d));
        this.Value = max / 255d;
    }
}