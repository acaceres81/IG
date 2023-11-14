namespace AginteKoadroa
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.BezSal = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.userControl11 = new GrafikoaDll.UserControl1();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.BezSal)).BeginInit();
            this.SuspendLayout();
            // 
            // BezSal
            // 
            chartArea1.Name = "ChartArea1";
            this.BezSal.ChartAreas.Add(chartArea1);
            this.helpProvider1.SetHelpString(this.BezSal, "Grafiko honek saltzaile bakoitzak dituen bezeroak erakusten ditu.");
            this.BezSal.Location = new System.Drawing.Point(12, 338);
            this.BezSal.Name = "BezSal";
            this.BezSal.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series1.Name = "Series1";
            this.BezSal.Series.Add(series1);
            this.helpProvider1.SetShowHelp(this.BezSal, true);
            this.BezSal.Size = new System.Drawing.Size(463, 331);
            this.BezSal.TabIndex = 0;
            this.BezSal.Text = "Bezeroak Saltzaile Bakoitzeko";
            title1.Name = "Title1";
            title1.Text = "Bezeroak Saltzaile bakoitzeko";
            this.BezSal.Titles.Add(title1);
            this.BezSal.Click += new System.EventHandler(this.chart1_Click);
            // 
            // userControl11
            // 
            this.userControl11.Location = new System.Drawing.Point(589, 338);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(442, 301);
            this.userControl11.TabIndex = 1;
            this.toolTip1.SetToolTip(this.userControl11, "Grafiko honek beste zerbait erakusten du.\r\n");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1364, 695);
            this.Controls.Add(this.userControl11);
            this.Controls.Add(this.BezSal);
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BezSal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart BezSal;
        private GrafikoaDll.UserControl1 userControl11;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

