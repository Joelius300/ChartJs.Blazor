using ChartJs.Common;
using ChartJs.Common.Enums;

namespace ChartJs.BarChart
{
    /// <summary>
    /// Config for a <see cref="Charts.ChartJsBarChart"/>.
    /// </summary>
    public class BarConfig : ConfigBase<BarOptions, BarData>
    {
        /// <summary>
        /// Creates a new instance of the <see cref="BarConfig"/> class.
        /// </summary>
        public BarConfig(ChartType type = null) : base(type ?? ChartType.Bar) { }
    }
}