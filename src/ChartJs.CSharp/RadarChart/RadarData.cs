using System.Collections.Generic;

namespace ChartJs.RadarChart
{
    public class RadarData
    {
        public List<string> Labels { get; set; } = new List<string>();

        public List<RadarDataset> Datasets { get; set; }   = new List<RadarDataset>();
    }
}