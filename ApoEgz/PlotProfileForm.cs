using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApoEgz
{
    public partial class PlotProfileForm : Form
    {
        //**************************************************************************************************************
        // zmienne globalne
        Image img;
        Bitmap bmpOrg;
        Bitmap bmpCln;
        PlotChartForm plotChFrm = new PlotChartForm();
        string colorModel = "";
        //**************************************************************************************************************
        public PlotProfileForm(Image picture,string model)
        {
            InitializeComponent();
            colorModel = model;
            img = picture;
            pictureBoxPlotImage.Image = img;
            bmpOrg = (Bitmap)pictureBoxPlotImage.Image;
            bmpCln = (Bitmap)bmpOrg.Clone();
            plotChFrm.Owner = this;
        }
        //**************************************************************************************************************
        // lista pointow
        List<Point> lp = new List<Point>();
        dynamic X1, X2, Y1, Y2;
        //**************************************************************************************************************
        private void pictureBoxPlotImage_MouseDown(object sender, MouseEventArgs e)
        {
            lp.Add(new Point(e.X, e.Y));
            if (lp.Count <= 2)
            {

                if (lp.Count > 1)
                {
                    pictureBoxPlotImage.Image = bmpCln;
                    using (Graphics g = Graphics.FromImage(pictureBoxPlotImage.Image)) // rysuje linie
                    {
                        g.DrawLine(Pens.Yellow, lp[0], lp[1]);
                        X1 = lp[0].X;
                        X2 = lp[1].X;
                        Y1 = lp[0].Y;
                        Y2 = lp[1].Y;
                        pictureBoxPlotImage.Refresh();
                        PlotValues();
                        DrawPlotProfile();
                    }
                }
            }
            else
            {
                pictureBoxPlotImage.Image = bmpOrg;
                bmpCln = (Bitmap)bmpOrg.Clone();
                pictureBoxPlotImage.Refresh();
                lp.Clear();
                plotChFrm.Hide();
            }
        }

        List<double> R_H = new List<double>();
        List<double> G_S = new List<double>();
        List<double> B_V = new List<double>();
        //**************************************************************************************************************
        // wypelnia liste 
        public void PlotValues()
        {
            R_H.Clear();
            G_S.Clear();
            B_V.Clear();

            int x1 = X1;
            int x2 = X2;
            int y1 = Y1;
            int y2 = Y2;

            double deltaX = Math.Abs(x2 - x1);
            double deltaY = Math.Abs(y2 - y1);
            int signX = x1 < x2 ? 1 : -1;
            int signY = y1 < y2 ? 1 : -1;
            double error = deltaX - deltaY;
            List<Point> res = new List<Point>();
            while (x1 != x2 || y1 != y2)
            {
                res.Add(new Point(x1, y1));
                double error2 = error * 2;
                if (error2 > -deltaY)
                {
                    error -= deltaY;
                    x1 += signX;
                }
                if (error2 < deltaX)
                {
                    error += deltaX;
                    y1 += signY;
                }
            }
            res.Add(new Point(x2, y2));


            Color color;
            Bitmap bmp = bmpOrg;
            for (int i = 0; i < res.Count; ++i)
            {
                color = bmp.GetPixel(res[i].X, res[i].Y);
                if (colorModel == "HSV")
                {
                    R_H.Add((double)color.GetHue());
                    G_S.Add((double)color.GetSaturation());
                    B_V.Add((double)color.GetBrightness());
                }
                else 
                {
                    R_H.Add((double)color.R);
                    G_S.Add((double)color.G);
                    B_V.Add((double)color.B);
                }
            }
        }
        //**************************************************************************************************************
        // forma z wykresami
        void DrawPlotProfile()
        {
            if (colorModel == "RGB")
            {
                plotChFrm.chartTop.Series["Series1"].LegendText = "RED";
                plotChFrm.chartMid.Series["Series1"].LegendText = "GREEN";
                plotChFrm.chartBottom.Series["Series1"].LegendText = "BLUE";
            }
            else 
            {
                plotChFrm.chartTop.Series["Series1"].LegendText = "HUE";
                plotChFrm.chartMid.Series["Series1"].LegendText = "SATURATION";
                plotChFrm.chartBottom.Series["Series1"].LegendText = "VALUE";
            }
            
            plotChFrm.chartTop.Series["Series1"].Color = Color.Red;
            plotChFrm.chartTop.Series["Series1"].Points.Clear();
            plotChFrm.chartTop.Series["Series1"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

            
            plotChFrm.chartMid.Series["Series1"].Color = Color.Green;
            plotChFrm.chartMid.Series["Series1"].Points.Clear();
            plotChFrm.chartMid.Series["Series1"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

            
            plotChFrm.chartBottom.Series["Series1"].Color = Color.Blue;
            plotChFrm.chartBottom.Series["Series1"].Points.Clear();
            plotChFrm.chartBottom.Series["Series1"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            for (int i = 0; i < R_H.Count; ++i)
            {
                plotChFrm.chartTop.Series["Series1"].Points.AddXY(i, R_H[i]);
            }
            for (int i = 0; i < G_S.Count; ++i)
            {
                plotChFrm.chartMid.Series["Series1"].Points.AddXY(i, G_S[i]);
            }
            for (int i = 0; i < B_V.Count; ++i)
            {
                plotChFrm.chartBottom.Series["Series1"].Points.AddXY(i, B_V[i]);
            }
            plotChFrm.Show();
        }
    }
}
//**************************************************************************************************************