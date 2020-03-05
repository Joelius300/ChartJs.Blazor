using ChartJs.Common.Properties;

namespace ChartJs.LineChart
{
    // TODO: check if this would apply to more charts (https://www.chartjs.org/docs/latest/general/interactions) 
    // and if so rename and reuse this
    /// <summary>
    /// The hover-subconfig of <see cref="LineOptions"/>
    /// </summary>
    public class LineOptionsHover : Tooltips
    {
        /// <summary>
        /// Duration in milliseconds it takes to animate hover style changes.
        /// </summary>
        public long AnimationDuration { get; set; }
    }
}