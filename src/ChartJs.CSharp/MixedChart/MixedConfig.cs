using ChartJs.Common;
using ChartJs.Common.Enums;

namespace ChartJs.MixedChart
{
    public class MixedConfig<TData> : ConfigBase<MixedOptions, MixedData<TData>>
    {
        public MixedConfig() : base(ChartType.Bar) // This is not a mistake
        {
        }
    }
}