using ChartJs.Common;
using ChartJs.Common.Enums;

namespace ChartJs.ScatterChart
{
    public class ScatterConfig : ConfigBase<ScatterOptions, ScatterData>
    {
        public ScatterConfig() : base(ChartType.Scatter) { }
    }
}