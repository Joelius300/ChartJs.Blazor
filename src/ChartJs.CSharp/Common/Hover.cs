using ChartJs.Common.Handlers.OnHover;

namespace ChartJs.Common
{
    public class Hover
    {
        public long? AnimationDuration { get; set; } = 400;
        public bool? Intersect { get; set; } = true;
        public string Mode { get; set; } = "point";
        public IHoverHandler OnHover { get; set; }
    }
}