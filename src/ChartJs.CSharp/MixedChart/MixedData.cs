using System.Collections.Generic;

namespace ChartJs.MixedChart
{
    public class MixedData<TData>
    {
        public List<string> Labels { get; set; } = new List<string>();

        public List<IMixableDataset<TData>> Datasets { get; set; }
    }
}