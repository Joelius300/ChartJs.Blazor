using ChartJs.Common;
using ChartJs.Common.Enums;

namespace ChartJs.RadarChart
{
    public class RadarConfig : ConfigBase<RadarOptions, RadarData>
    {
        public RadarConfig() : base(ChartType.Radar) { }
    }
}