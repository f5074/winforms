using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;
using F5074.Common.Controls;

namespace F5074.Common.Helper
{
    public static class SeriesHelper
    {
        public static void InitChartData(this BaseChart basechart)
        {
            basechart.Series.Clear();
            string[] arrSeries = { "A", "B", "C", "D" };
            Random rd = new Random();
            basechart.Palette = ChartColorPalette.BrightPastel;
            basechart.Titles.Add("Test");
            for (int x = 0; x < arrSeries.Length; x++)
            {
                Series series = basechart.Series.Add(arrSeries[x]);
                series.Points.Add(rd.Next(50));
            }

        }

    }
}
