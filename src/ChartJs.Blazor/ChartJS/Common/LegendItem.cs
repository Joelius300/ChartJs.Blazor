﻿using ChartJs.Blazor.ChartJS.Common.Enums;
using ChartJs.Blazor.ChartJS.Common.Properties;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChartJs.Blazor.ChartJS.Common
{
    /// <summary>
    /// The model of the legend items which are displayed in the chart.
    /// <para>As per documentation here https://www.chartjs.org/docs/latest/configuration/legend.html#legend-item-interface </para>
    /// </summary>
    // TODO Test if this is deserialized correctly (by System.Text.Json) because of the string enums.
    public class LegendItem
    {
        /// <summary>
        /// The index of the dataset this legend item corresponds to. DO NOT set this value when returning an instance of this class to ChartJs.
        /// Only use this property when retrieving the index in a legend-event.
        /// </summary>
        public int? Index { get; set; } // in 2.9 this changes to DatasetIndex

        /// <summary>
        /// Gets or sets the label-text that will be displayed.
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// Gets or sets the color (style) of the legend box.
        /// <para>See <see cref="Util.ColorUtil"/> for working with colors.</para>
        /// </summary>
        public string FillStyle { get; set; }

        /// <summary>
        /// If true, this item represents a hidden dataset. Label will be rendered with a strike-through effect.
        /// </summary>
        public bool? Hidden { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="BorderCapStyle"/> for the legend box border.
        /// </summary>
        public BorderCapStyle LineCap { get; set; }

        /// <summary>
        /// Gets or sets the line dash segments for the legend box border. Details on https://developer.mozilla.org/en-US/docs/Web/API/CanvasRenderingContext2D/setLineDash.
        /// </summary>
        public double[] LineDash { get; set; }

        /// <summary>
        /// Gets or sets the line dash offset. Details on https://developer.mozilla.org/en-US/docs/Web/API/CanvasRenderingContext2D/lineDashOffset.
        /// </summary>
        public double? LineDashOffset { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="BorderJoinStyle"/> of the legend box border.
        /// </summary>
        public BorderJoinStyle LineJoin { get; set; }

        /// <summary>
        /// Gets or sets the width of the box border.
        /// </summary>
        public double? LineWidth { get; set; }

        /// <summary>
        /// Gets or sets the color (style) of the legend box border.
        /// <para>See <see cref="Util.ColorUtil"/> for working with colors.</para>
        /// </summary>
        public string StrokeStyle { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="PointStyle"/> of the legend box (only used if <see cref="LegendLabels.UsePointStyle"/> is true). 
        /// </summary>
        public PointStyle PointStyle { get; set; }

        /// <summary>
        /// Gets or sets the rotation of the point in degrees (only used if <see cref="LegendLabels.UsePointStyle"/> is true).
        /// </summary>
        public double? Rotation { get; set; }
    }
}
