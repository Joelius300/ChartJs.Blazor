using ChartJs.Common;

namespace ChartJs.BubbleChart
{
    public class BubbleDataPoint : Point
    {
        public BubbleDataPoint()
        {
        }

        public BubbleDataPoint(double x, double y, double r) : base(x, y)
        {
            this.r = r;
        }

        /// <summary>
        /// Bubble radius, in pixels, not scaled
        /// </summary>
        public double r { get; set; }
    }
}