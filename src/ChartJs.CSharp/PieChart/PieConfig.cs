using ChartJs.Common;
using ChartJs.Common.Enums;

namespace ChartJs.PieChart
{
    /// <summary>
    /// Config for a <see cref="PieConfig"/>.
    /// </summary>
    public class PieConfig : ConfigBase<PieOptions, PieData>
    {
        /// <summary>
        /// Creates a new instance of <see cref="PieConfig"/>.
        /// </summary>
        public PieConfig() : base(ChartType.Pie)
        {
        }
    }
}