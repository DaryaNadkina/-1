using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            chart1.Legends.Clear();
            chart2.Legends.Clear();
            chart3.Legends.Clear();
        }

        private void Calculate_Click(object sender, EventArgs e)
        {

            double radius = Convert.ToDouble(radiusTB.Text);
            double velocity = Convert.ToDouble(velocityTB.Text);
            double dtime = Convert.ToDouble(timeTB.Text);
            double fi = 0;
            double omega = velocity / Math.Sqrt(radius * 9.8);
            Series series1 = new Series();
            Series series2 = new Series();
            Series series3 = new Series();

            for (double t = 0; t <= 10; t+=dtime)
            {
                series1.Points.AddXY(t, fi);
                series2.Points.AddXY(t, omega);
                series3.Points.AddXY(fi, omega);
                omega = omega - dtime * Math.Sin(fi);
                fi = fi + dtime * omega;
            }
            chart1.Series.Add(series1);
            chart2.Series.Add(series2);
            chart3.Series.Add(series3);

            series1.ChartType = SeriesChartType.Spline;
            series2.ChartType = SeriesChartType.Spline;
            series3.ChartType = SeriesChartType.Spline;

        }
    }
}
