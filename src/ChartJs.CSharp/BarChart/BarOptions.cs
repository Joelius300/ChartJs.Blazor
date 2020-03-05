using ChartJs.Common;

namespace ChartJs.BarChart
{
    /// <summary>
    /// The options-subconfig of a <see cref="BarConfig"/>.
    /// </summary>
    public class BarOptions : BaseConfigOptions
    {
        /// <summary>
        /// Gets or sets the scales for the <see cref="ChartJsBarChart"/>.
        /// </summary>
        public BarScales Scales { get; set; }
    }
}