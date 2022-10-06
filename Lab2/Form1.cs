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
using System.Globalization;
using System.Threading;

namespace Lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            CultureInfo temp_culture = Thread.CurrentThread.CurrentCulture;
            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("en-US");
        }

        private List<double> R = new List<double>();
        private List<double> X = new List<double>();
        private List<int> numX = new List<int>();

        private void RArray()
        {
            int n = 12;
            while (R.Count < 10000)
            {
                R.Clear();

                int r = (int)(Math.Pow(2, n) - 1 - n);
                int m = (int)(Math.Pow(2, n) - n);
                int a = (int)(Math.Pow(2, n - 1) - n);

                Boolean flag = true;
                int between;
                double x = new double();

                between = a * r;
                between = between % m;
                x = (double)between / m;
                R.Add(x);

                while (flag)
                {
                    double xC = new double();
                    between = a * between;
                    between = between % m;
                    xC = (double)between / m;
                    R.Add(xC);

                    if (xC == R[0]) flag = false;

                    //for (int i = 0; i < R.Count - 2; i++)
                    //{
                    //    if (xC == R[i])
                    //    {
                    //        flag = false;
                    //        break;
                    //    }
                    //}
                }
                n++;

            }

        }

        private void Draw()
        {
            double x1 = 0, x2 = 0.05;

            double xMin = X[0];
            double xMax = X[0];

            for(int i=0; i<X.Count; i++)
            {
                if(X[i] < xMin)
                {
                    xMin = X[i];
                }
                if (X[i] > xMax)
                {
                    xMax = X[i];
                }

            }

            double steep = (xMax - xMin) / 20;

            x1 = xMin;
            x2 = xMin + steep;
            while (x1 < xMax)
            {
                int xNum = new int();
                xNum = 0;

                for (int i = 0; i < X.Count; i++)
                {
                    if (x1 < X[i] && X[i] <= x2)
                    {
                        xNum++;
                    }
                }

                numX.Add(xNum);

                x1 += steep;
                x2 += steep;
            }

            var series = new Series
            {
                ChartType = SeriesChartType.Column,
                ChartArea = "ChartArea",
            };

            double x = xMin + steep;
            for (int i = 0; i < numX.Count; i++)
            {

                double y = (double)numX[i] / X.Count;

                //double xForm = (int)(x * 1000);
                //xForm = Math.Round(x);
                //xForm = (double)x / 10000;

                series.Points.AddXY(x, y);

                x += steep;
            }

            Chart.Series.Add(series);


        }

        private void mathFuntion()
        {
            double mathProject = 0;
            for (int i = 0; i < X.Count; i++)
            {
                mathProject += X[i];
            }
            mathProject = (double)mathProject / X.Count;

            math.Text = mathProject.ToString();

            double disper = 0;

            for (int i = 0; i < X.Count; i++)
            {
                disper = disper + Math.Pow((X[i] - mathProject),2);
            }
            disper = disper / X.Count;

            d.Text = disper.ToString();

            sko.Text = (Math.Sqrt(disper)).ToString();
        }

        private void fFunction()
        {

            double A = Convert.ToDouble(a.Text);
            double B = Convert.ToDouble(b.Text);

            for(int i=0; i < R.Count; i++)
            {
                double x = new double();
                x = A + (B - A) * R[i];
                X.Add(x);
            }

            Draw();

            mathFuntion();

            //math.Text = (((double)A + (double)B) / 2).ToString();
            //double D = ((Math.Pow(B, 2) + Math.Pow(A, 2)) / 12);
            //d.Text = ((double)D).ToString();
            //sko.Text = Math.Sqrt(D).ToString();
        }

        private void GaysFunction()
        {
            double mathGays = Convert.ToDouble(MathSleepForm.Text);
            double skoGays = Convert.ToDouble(SKOForm.Text);

            int n = 6;
            int endCycle = 0;

            try
            {
                for (int i = 0; i < R.Count; i++)
                {
                    double res = 0;

                    endCycle = i + n;
                    int k;
                    for (k = i; k < endCycle; k++)
                    {
                        res += R[k];
                    }
                    k = i;
                    res = res - (n/2);

                    double x = new double();

                    x = mathGays + skoGays * Math.Sqrt(12/n) * res;

                    X.Add(x);

                }
            }
            catch { }

            Draw();

            mathFuntion();

            //math.Text = mathGays.ToString();
            //sko.Text = skoGays.ToString();
            //d.Text = Math.Pow(skoGays, 2).ToString();
        }

        private void ExpFunction()
        {
            double l = Convert.ToDouble(LamdoExp.Text);

            Random rand = new Random();
            for(int i=0; i<X.Count; i++)
            {

            }

            for(int i = 0; i < R.Count; i++)
            {
                double x = new double();
                x = (double)(-1*Math.Log(R[i]))/l;
                X.Add(x);
            }

            Draw();

            mathFuntion();

            //math.Text = (1/ (double)l).ToString();
            //double D = 1/Math.Pow(l, 2);
            //d.Text = D.ToString();
            //sko.Text = (1 / (double)l).ToString();
        }

        private void GammaFunction()
        {
            double l = Convert.ToDouble(LamdoGamma.Text);
            double n = Convert.ToDouble(N.Text);

            int i = 0;
            int cycle = 1;
            while(i < R.Count)
            {
                double x = new double();
                x = 1;
                while ((i < n * cycle)&&(i<R.Count))
                {
                    x *= R[i];
                    i++;
                }
                x = (double)(-1*Math.Log(x))/l;
                X.Add(x);
                cycle++;

            }

            Draw();

            mathFuntion();

            //math.Text = ((double)n/l).ToString();
            //double D = (double)n / Math.Pow(l, 2);
            //d.Text = D.ToString();
            //sko.Text = Math.Sqrt(D).ToString();
        }

        private void TreyFuction()
        {
            double a = Convert.ToDouble(ATreyForm.Text);
            double b = Convert.ToDouble(BTreyForm.Text);

            try
            {

                for (int i = 0; i < R.Count - 1; i++)
                {
                    double x = new double();

                    x = a + (b - a) * (Math.Max(R[i], R[i + 1]));

                    X.Add(x);
                    i++;
                }
            }
            catch { }

            mathFuntion();

            //math.Text = (((double)a + (double)b) / 2).ToString();
            //double D = ((Math.Pow(b, 2) + Math.Pow(a, 2)) / 12);
            //d.Text = ((double)D).ToString();
            //sko.Text = Math.Sqrt(D).ToString();

            Draw();
        }

        private void SimsonFunction()
        {
            double A = Convert.ToDouble(aSimForm.Text);
            double B = Convert.ToDouble(bSimForm.Text);

            A /= 2;
            B  = B/2;

            double xRes;

            for (int i = 0; i < R.Count-1; i++)
            {
                double x = new double();
                xRes = A + (B - A) * R[i];
                x = xRes + (A + (B - A) * R[i+1]);
                X.Add(x);
                i++;
            }

            Draw();

            mathFuntion();

            //math.Text = (((double)A + (double)B) / 2).ToString();
            //double D = ((Math.Pow(B, 2) + Math.Pow(A, 2)) / 12);
            //d.Text = ((double)D).ToString();
            //sko.Text = Math.Sqrt(D).ToString();

        }

        private void CulculButt_Click(object sender, EventArgs e)
        {
            R.Clear();
            numX.Clear();
            
            X.Clear();
            try
            {
                Chart.Series[0].Points.Clear();
                Chart.Series.Clear();
            }
            catch { }

            RArray();
            switch (comboBox.SelectedIndex)
            {
                case 0:
                    fFunction();
                    break;
                case 1:
                    GaysFunction();
                    break;
                case 2:
                    ExpFunction();
                    break;
                case 3:
                    GammaFunction();
                    break;
                case 4:
                    TreyFuction();
                    break;
                case 5:
                    SimsonFunction();
                    break;
                default:
                    break;
            }
        }

    }
}
