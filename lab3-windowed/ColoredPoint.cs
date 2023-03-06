using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace lab3_windowed
{
    class ColoredPoint
    {

        private int x;

        private int y;

        private Color color;

        public int X
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
            }
        }

        public int Y
        {
            get
            {
                return y;
            }
            set
            {
                y = value;
            }
        }

        public Color Color
        {
            get
            {
                return color;
            }
            set
            {
                color = value;
            }
        }

        public DataPoint Point
        {
            get
            {
                DataPoint point = new DataPoint(x, y);
                point.Color = System.Drawing.Color.FromArgb(color.R, color.G, color.B);
                return point;
            }
        }

        public ColoredPoint(Color color, int x, int y)
        {
            this.color = color;
            this.x = x;
            this.y = y;
        }

        public ColoredPoint(int x, int y) : this(new Color(0, 0, 0), x, y)
        {
        }

        public override string ToString()
        {
            return "ColoredPoint{x = " + x + ", y = " + y + ", color = " + color.ToString() + "}";
        }

    }

    class Color
    {
        private int r;
        private int g;
        private int b;

        public int R
        {
            get
            {
                return r;
            }
            set
            {
                ValidateRange(value, "R");
                r = value;
            }
        }

        public int G
        {
            get
            {
                return g;
            }
            set
            {
                ValidateRange(value, "G");
                g = value;
            }
        }

        public int B
        {
            get
            {
                return b;
            }
            set
            {
                ValidateRange(value, "B");
                b = value;
            }
        }

        public Color(int r, int g, int b)
        {
            ValidateRange(r, "R");
            ValidateRange(g, "G");
            ValidateRange(b, "B");
            this.r = r;
            this.g = g;
            this.b = b;
        }

        private void ValidateRange(int componentColor, string componentName)
        {
            if (componentColor < 0 || componentColor > 255)
            {
                throw new ArgumentOutOfRangeException(componentName + " must be in range from 0 to 255");
            }
        }

        public override string ToString()
        {
            return "Color{R = " + r + ", G = " + g + ", B = " + b + "}";
        }

    }
}
