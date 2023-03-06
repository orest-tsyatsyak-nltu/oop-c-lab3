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

namespace lab3_windowed
{
    public partial class ColoredPointWindow : Form
    {

        private ColoredPoint coloredPoint = new ColoredPoint(0, 0);

        public ColoredPointWindow()
        {
            InitializeComponent();
            graph.ChartAreas["points"].AxisX.Minimum = 0;
            graph.ChartAreas["points"].AxisX.Maximum = 100;
            graph.ChartAreas["points"].AxisY.Minimum = 0;
            graph.ChartAreas["points"].AxisY.Maximum = 100;
            graph.Series["points"].Points.Add(coloredPoint.Point);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                coloredPoint.X = int.Parse(xField.Text);
                coloredPoint.Y = int.Parse(yField.Text);
                int r = int.Parse(rField.Text);
                int g = int.Parse(gField.Text);
                int b = int.Parse(bField.Text);
                coloredPoint.Color.R = r;
                coloredPoint.Color.G = g;
                coloredPoint.Color.B = b;
                graph.Series["points"].Points.Add(coloredPoint.Point);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch
            {
                MessageBox.Show("Something went wrong");
            }
        }
    }
}
