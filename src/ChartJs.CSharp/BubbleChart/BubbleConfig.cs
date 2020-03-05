using ChartJs.Common;
using ChartJs.Common.Enums;

namespace ChartJs.BubbleChart
{
    public class BubbleConfig : ConfigBase<BubbleOptions, BubbleData>
    {
        public BubbleConfig() : base(ChartType.Bubble) { }
    }
}