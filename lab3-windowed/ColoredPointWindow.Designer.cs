namespace lab3_windowed
{
    partial class ColoredPointWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.addPoint = new System.Windows.Forms.Button();
            this.bField = new System.Windows.Forms.TextBox();
            this.B = new System.Windows.Forms.Label();
            this.gField = new System.Windows.Forms.TextBox();
            this.G = new System.Windows.Forms.Label();
            this.rField = new System.Windows.Forms.TextBox();
            this.R = new System.Windows.Forms.Label();
            this.yField = new System.Windows.Forms.TextBox();
            this.Y = new System.Windows.Forms.Label();
            this.xField = new System.Windows.Forms.TextBox();
            this.X = new System.Windows.Forms.Label();
            this.graph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.graph)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.addPoint);
            this.panel1.Controls.Add(this.bField);
            this.panel1.Controls.Add(this.B);
            this.panel1.Controls.Add(this.gField);
            this.panel1.Controls.Add(this.G);
            this.panel1.Controls.Add(this.rField);
            this.panel1.Controls.Add(this.R);
            this.panel1.Controls.Add(this.yField);
            this.panel1.Controls.Add(this.Y);
            this.panel1.Controls.Add(this.xField);
            this.panel1.Controls.Add(this.X);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(206, 450);
            this.panel1.TabIndex = 0;
            // 
            // addPoint
            // 
            this.addPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addPoint.Location = new System.Drawing.Point(36, 354);
            this.addPoint.Name = "addPoint";
            this.addPoint.Size = new System.Drawing.Size(122, 42);
            this.addPoint.TabIndex = 10;
            this.addPoint.Text = "Add Point";
            this.addPoint.UseVisualStyleBackColor = true;
            this.addPoint.Click += new System.EventHandler(this.button1_Click);
            // 
            // bField
            // 
            this.bField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bField.Location = new System.Drawing.Point(31, 301);
            this.bField.Name = "bField";
            this.bField.Size = new System.Drawing.Size(134, 23);
            this.bField.TabIndex = 9;
            // 
            // B
            // 
            this.B.AutoSize = true;
            this.B.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.B.Location = new System.Drawing.Point(61, 273);
            this.B.Name = "B";
            this.B.Size = new System.Drawing.Size(76, 25);
            this.B.TabIndex = 8;
            this.B.Text = "Enter B";
            // 
            // gField
            // 
            this.gField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gField.Location = new System.Drawing.Point(31, 247);
            this.gField.Name = "gField";
            this.gField.Size = new System.Drawing.Size(134, 23);
            this.gField.TabIndex = 7;
            // 
            // G
            // 
            this.G.AutoSize = true;
            this.G.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.G.Location = new System.Drawing.Point(61, 219);
            this.G.Name = "G";
            this.G.Size = new System.Drawing.Size(78, 25);
            this.G.TabIndex = 6;
            this.G.Text = "Enter G";
            // 
            // rField
            // 
            this.rField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rField.Location = new System.Drawing.Point(30, 193);
            this.rField.Name = "rField";
            this.rField.Size = new System.Drawing.Size(134, 23);
            this.rField.TabIndex = 5;
            // 
            // R
            // 
            this.R.AutoSize = true;
            this.R.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.R.Location = new System.Drawing.Point(60, 165);
            this.R.Name = "R";
            this.R.Size = new System.Drawing.Size(76, 25);
            this.R.TabIndex = 4;
            this.R.Text = "Enter R";
            // 
            // yField
            // 
            this.yField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.yField.Location = new System.Drawing.Point(31, 111);
            this.yField.Name = "yField";
            this.yField.Size = new System.Drawing.Size(134, 23);
            this.yField.TabIndex = 3;
            // 
            // Y
            // 
            this.Y.AutoSize = true;
            this.Y.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Y.Location = new System.Drawing.Point(62, 83);
            this.Y.Name = "Y";
            this.Y.Size = new System.Drawing.Size(76, 25);
            this.Y.TabIndex = 2;
            this.Y.Text = "Enter Y";
            // 
            // xField
            // 
            this.xField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.xField.Location = new System.Drawing.Point(32, 57);
            this.xField.Name = "xField";
            this.xField.Size = new System.Drawing.Size(134, 23);
            this.xField.TabIndex = 1;
            // 
            // X
            // 
            this.X.AutoSize = true;
            this.X.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.X.Location = new System.Drawing.Point(62, 29);
            this.X.Name = "X";
            this.X.Size = new System.Drawing.Size(77, 25);
            this.X.TabIndex = 0;
            this.X.Text = "Enter X";
            // 
            // graph
            // 
            chartArea1.Name = "points";
            this.graph.ChartAreas.Add(chartArea1);
            this.graph.Location = new System.Drawing.Point(267, 78);
            this.graph.Name = "graph";
            series1.ChartArea = "points";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series1.LegendText = "asd";
            series1.Name = "points";
            this.graph.Series.Add(series1);
            this.graph.Size = new System.Drawing.Size(436, 300);
            this.graph.TabIndex = 1;
            this.graph.Text = "chart1";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // ColoredPointWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.graph);
            this.Controls.Add(this.panel1);
            this.Name = "ColoredPointWindow";
            this.Text = "ColoredPoint";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.graph)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart graph;
        private System.Windows.Forms.Label X;
        private System.Windows.Forms.TextBox yField;
        private System.Windows.Forms.Label Y;
        private System.Windows.Forms.TextBox xField;
        private System.Windows.Forms.Button addPoint;
        private System.Windows.Forms.TextBox bField;
        private System.Windows.Forms.Label B;
        private System.Windows.Forms.TextBox gField;
        private System.Windows.Forms.Label G;
        private System.Windows.Forms.TextBox rField;
        private System.Windows.Forms.Label R;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}