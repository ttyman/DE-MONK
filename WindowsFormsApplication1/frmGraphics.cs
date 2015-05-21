using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskPartitionTest
{
    public partial class frmGraphics : Form
    {
        public frmGraphics()
        {
            InitializeComponent();
        }

        private void frmGraphics_Load(object sender, EventArgs e)
        {

        }

        public void UpdateScreen( List<double> SerieSequence, double BottomValue, double TopValue, int ScaleStart, int ScaleFinish)
        {
            chtGraphics.Series.Clear();
            chtGraphics.Series.Add("SO_DE");
            //chtGraphics.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            chtGraphics.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            chtGraphics.Series[0].Color = Color.Red;
            //chtGraphics.Series[0].
            chtGraphics.Legends.Clear();

            chtGraphics.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
            chtGraphics.ChartAreas[0].AxisX.ScrollBar.IsPositionedInside = false;
            chtGraphics.ChartAreas[0].AxisX.ScrollBar.Enabled = false;
            chtGraphics.ChartAreas[0].AxisX.ScaleView.Zoom((double)ScaleStart, (double)ScaleFinish);

            chtGraphics.ChartAreas[0].AxisY.ScaleView.Zoomable = true;
            chtGraphics.ChartAreas[0].AxisY.ScrollBar.IsPositionedInside = false;
            chtGraphics.ChartAreas[0].AxisY.ScrollBar.Enabled = false;
            chtGraphics.ChartAreas[0].AxisY.ScaleView.Zoom(BottomValue, TopValue);
            
            //foreach (double value in SerieSequence)
            //{
            //    chtGraphics.Series[0].Points.AddY(value);
            //}
            for(int i=0; i < SerieSequence.Count; i++)
            {
                chtGraphics.Series[0].Points.AddXY((double)i, SerieSequence[i]);
            }

            chtGraphics.ChartAreas[0].RecalculateAxesScale();
            
            
        }
    }
}
