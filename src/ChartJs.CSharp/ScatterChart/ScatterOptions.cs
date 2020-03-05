using ChartJs.Common;
using ChartJs.Common.Enums;

namespace ChartJs.ScatterChart
{
    public class ScatterOptions : BaseConfigOptions
    {
        public InteractionMode HoverMode { get; set; } = InteractionMode.Nearest;

        public bool Intersect { get; set; }

        public ScatterScales Scales { get; set; }
    }
}