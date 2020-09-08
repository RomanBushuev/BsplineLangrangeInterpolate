using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;
using OxyPlot.WindowsForms;
using HomeWorkUserInterface;
using System.IO;
using HomeWorkBushuev;

namespace HomeWorkUserInterface
{
    public partial class MainForm : Form
    {
        private string _fileName;
        private int N = 1000;
        private Dictionary<string, PlotModel> _plotModels = new Dictionary<string, PlotModel>();
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void PaintGraphs()
        {
            string fileName = _fileName;
            List<string> strings = File.ReadAllLines(fileName).ToList();

            List<double> x_s = strings
                .First()
                .Split(new char[] { '\t' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => double.Parse(x))
                .ToList();

            List<double> y_s = strings
                .Last()
                .Split(new char[] { '\t' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => double.Parse(x))
                .ToList();

            Langrange(x_s, y_s);
            LangrangeFirstDerivative(x_s, y_s);
            LangrangeSecondDerivative(x_s, y_s);
            CreateCubicSplain(x_s, y_s);
            CubicSplainDerivative(x_s, y_s);
            CubicSplainSecondVariant(x_s, y_s);
            CubicSplainSecondVariantDerivative(x_s, y_s);
        }

        public void DownloadSample()
        {
            PlotView plotView = new PlotView();
            plotView.Dock = DockStyle.Fill;
            panel1_1.Controls.Add(plotView);

            #region задание сетки для x
            LinearAxis XAxis = new LinearAxis
            {
                Position = AxisPosition.Bottom,
                Minimum = -20,
                Maximum = 20
            };

            LinearAxis YAxis = new LinearAxis();
            #endregion

            PlotModel plotModel = new PlotModel();
            plotView.Model = plotModel;
            plotView.Model.Series.Add(getSeries());
        }

        private Series getSeries()
        {
            int n = 10;
            FunctionSeries functionSeries = new FunctionSeries();
            for (int x = -10; x <= n; x++)
            {
                DataPoint dataPoint = new DataPoint(x, -41 * (x * x) + 50);
                functionSeries.Points.Add(dataPoint);
            }
            return functionSeries;
        }

        public void Langrange(IEnumerable<double> x_s,
            IEnumerable<double> y_s)
        {
            PlotView plotView = new PlotView();
            plotView.Dock = DockStyle.Fill;
            if(panel1_1.Controls.Count != 0)
                panel1_1.Controls.RemoveAt(0);
            panel1_1.Controls.Add(plotView);
            LinearAxis XAxis = new LinearAxis()
            {
                Position = AxisPosition.Bottom,
                Minimum = x_s.First(),
                Maximum = x_s.Last()
            };

            PlotModel plotModel = new PlotModel();
            plotView.Model = plotModel;

            Langrange langrange = new Langrange(x_s, y_s);
            List<double> plot_x = new List<double>();
            double step = (Math.Abs(x_s.First()) + Math.Abs(x_s.Last())) / N;
            for (int i = 0; i <= N; ++i)
            {
                plot_x.Add(x_s.First() + step * i);
            }

            List<double> plot_y = new List<double>();
            foreach (var x in plot_x)
            {
                plot_y.Add(langrange.GetLangrangePolynominal(x));
            }

            FunctionSeries functionSeries = new FunctionSeries();
            Series series = new LineSeries();
            for (int i = 0; i < plot_x.Count; ++i)
            {
                DataPoint dataPoint = new DataPoint(plot_x[i], plot_y[i]);
                functionSeries.Points.Add(dataPoint);
            }

            plotView.Model.Series.Add(functionSeries);
            if (_plotModels.ContainsKey("Langrange"))
            {
                _plotModels.Remove("Langrange");
            }
            _plotModels.Add("Langrange", plotModel);
        }

        public void LangrangeFirstDerivative(IEnumerable<double> x_s,
            IEnumerable<double> y_s)
        {
            PlotView plotView = new PlotView();
            plotView.Dock = DockStyle.Fill;
            if (panel1_2.Controls.Count != 0)
                panel1_2.Controls.RemoveAt(0);
            panel1_2.Controls.Add(plotView);
            LinearAxis XAxis = new LinearAxis()
            {
                Position = AxisPosition.Bottom,
                Minimum = x_s.First(),
                Maximum = x_s.Last()
            };

            PlotModel plotModel = new PlotModel();
            plotView.Model = plotModel;

            Langrange langrange = new Langrange(x_s, y_s);
            List<double> plot_x = new List<double>();
            double step = (Math.Abs(x_s.First()) + Math.Abs(x_s.Last())) / N;
            for (int i = 0; i <= N; ++i)
            {
                plot_x.Add(x_s.First() + step * i);
            }

            List<double> plot_y = new List<double>();
            foreach (var x in plot_x)
            {
                plot_y.Add(langrange.GetLangrangeFirstDerivative(x));
            }

            FunctionSeries functionSeries = new FunctionSeries();
            Series series = new LineSeries();
            for (int i = 0; i < plot_x.Count; ++i)
            {
                DataPoint dataPoint = new DataPoint(plot_x[i], plot_y[i]);
                functionSeries.Points.Add(dataPoint);
            }

            plotView.Model.Series.Add(functionSeries);
            if (_plotModels.ContainsKey("LangrangeFirstDerivative"))
            {
                _plotModels.Remove("LangrangeFirstDerivative");
            }
            _plotModels.Add("LangrangeFirstDerivative", plotModel);
        }

        public void LangrangeSecondDerivative(IEnumerable<double> x_s,
            IEnumerable<double> y_s)
        {
            PlotView plotView = new PlotView();
            plotView.Dock = DockStyle.Fill;
            if (panel1_3.Controls.Count != 0)
                panel1_3.Controls.RemoveAt(0);
            panel1_3.Controls.Add(plotView);
            LinearAxis XAxis = new LinearAxis()
            {
                Position = AxisPosition.Bottom,
                Minimum = x_s.First(),
                Maximum = x_s.Last()
            };

            PlotModel plotModel = new PlotModel();
            plotView.Model = plotModel;

            Langrange langrange = new Langrange(x_s, y_s);
            List<double> plot_x = new List<double>();
            double step = (Math.Abs(x_s.First()) + Math.Abs(x_s.Last())) / N;
            for (int i = 0; i <= N; ++i)
            {
                plot_x.Add(x_s.First() + step * i);
            }

            List<double> plot_y = new List<double>();
            foreach (var x in plot_x)
            {
                plot_y.Add(langrange.GetLangrangeSecondDerivative(x));
            }

            FunctionSeries functionSeries = new FunctionSeries();
            Series series = new LineSeries();
            for (int i = 0; i < plot_x.Count; ++i)
            {
                DataPoint dataPoint = new DataPoint(plot_x[i], plot_y[i]);
                functionSeries.Points.Add(dataPoint);
            }

            plotView.Model.Series.Add(functionSeries);
            if (_plotModels.ContainsKey("LangrangeSecondDerivative"))
            {
                _plotModels.Remove("LangrangeSecondDerivative");
            }
            _plotModels.Add("LangrangeSecondDerivative", plotModel);
        }

        public void CreateCubicSplain(IEnumerable<double> x_s,
            IEnumerable<double> y_s)
        {
            PlotView plotView = new PlotView();
            plotView.Dock = DockStyle.Fill;
            if (panel2_1.Controls.Count != 0)
                panel2_1.Controls.RemoveAt(0);
            panel2_1.Controls.Add(plotView);
            LinearAxis XAxis = new LinearAxis()
            {
                Position = AxisPosition.Bottom,
                Minimum = x_s.First(),
                Maximum = x_s.Last()
            };

            PlotModel plotModel = new PlotModel();
            plotView.Model = plotModel;

            var cubicSplain = CubicSplain.CreateCubicSpline(x_s.ToList(), y_s.ToList());
            //точки от 0 до 301 
            List<double> plot_x = new List<double>();
            double step = (Math.Abs(x_s.First()) + Math.Abs(x_s.Last())) / N;
            for (int i = 0; i <= N; ++i)
            {
                plot_x.Add(x_s.First() + step * i);
            }

            List<double> cub_y = new List<double>();
            foreach (double x in plot_x)
            {
                cub_y.Add(cubicSplain.Calc(x));
            }

            FunctionSeries functionSeries = new FunctionSeries();
            Series series = new LineSeries();
            for (int i = 0; i < plot_x.Count; ++i)
            {
                DataPoint dataPoint = new DataPoint(plot_x[i], cub_y[i]);
                functionSeries.Points.Add(dataPoint);
            }

            plotView.Model.Series.Add(functionSeries);
            if (_plotModels.ContainsKey("CubicSplain"))
            {
                _plotModels.Remove("CubicSplain");
            }
            _plotModels.Add("CubicSplain", plotModel);
        }

        public void CubicSplainDerivative(IEnumerable<double> x_s,
            IEnumerable<double> y_s)
        {
            PlotView plotView = new PlotView();
            plotView.Dock = DockStyle.Fill;
            if (panel2_FirstDerivative.Controls.Count != 0)
                panel2_FirstDerivative.Controls.RemoveAt(0);
            panel2_FirstDerivative.Controls.Add(plotView);
            LinearAxis XAxis = new LinearAxis()
            {
                Position = AxisPosition.Bottom,
                Minimum = x_s.First(),
                Maximum = x_s.Last()
            };

            PlotModel plotModel = new PlotModel();
            plotView.Model = plotModel;

            var cubicSplain = CubicSplain.CreateCubicSpline(x_s.ToList(), y_s.ToList());
            //точки от 0 до 301 
            List<double> plot_x = new List<double>();
            double step = (Math.Abs(x_s.First()) + Math.Abs(x_s.Last())) / N;
            for (int i = 0; i <= N; ++i)
            {
                plot_x.Add(x_s.First() + step * i);
            }

            List<double> cub_y = new List<double>();
            foreach (double x in plot_x)
            {
                cub_y.Add(cubicSplain.CalcFirstDerivative(x));
            }


            FunctionSeries functionSeries = new FunctionSeries();
            Series series = new LineSeries();
            for (int i = 0; i < plot_x.Count; ++i)
            {
                DataPoint dataPoint = new DataPoint(plot_x[i], cub_y[i]);
                functionSeries.Points.Add(dataPoint);
            }

            plotView.Model.Series.Add(functionSeries);
            if (_plotModels.ContainsKey("CubicSplainDerivative"))
            {
                _plotModels.Remove("CubicSplainDerivative");
            }
            _plotModels.Add("CubicSplainDerivative", plotModel);
        }

        public void CubicSplainSecondVariant(IEnumerable<double> x_s,
            IEnumerable<double> y_s)
        {
            PlotView plotView = new PlotView();
            plotView.Dock = DockStyle.Fill;
            if (panel3_1.Controls.Count != 0)
                panel3_1.Controls.RemoveAt(0);
            panel3_1.Controls.Add(plotView);
            LinearAxis XAxis = new LinearAxis()
            {
                Position = AxisPosition.Bottom,
                Minimum = x_s.First(),
                Maximum = x_s.Last()
            };

            PlotModel plotModel = new PlotModel();
            plotView.Model = plotModel;

            var cubicSplain = CubicSplain.CreateCubicSplineSecond(x_s.ToList(), y_s.ToList());
            //точки от 0 до 301 
            List<double> plot_x = new List<double>();
            double step = (Math.Abs(x_s.First()) + Math.Abs(x_s.Last())) / N;
            for (int i = 0; i <= N; ++i)
            {
                plot_x.Add(x_s.First() + step * i);
            }

            List<double> cub_y = new List<double>();
            foreach (double x in plot_x)
            {
                cub_y.Add(cubicSplain.Calc(x));
            }


            FunctionSeries functionSeries = new FunctionSeries();
            Series series = new LineSeries();
            for (int i = 0; i < plot_x.Count; ++i)
            {
                DataPoint dataPoint = new DataPoint(plot_x[i], cub_y[i]);
                functionSeries.Points.Add(dataPoint);
            }

            plotView.Model.Series.Add(functionSeries);
            if (_plotModels.ContainsKey("CubicSplainSecondVariant"))
            {
                _plotModels.Remove("CubicSplainSecondVariant");
            }
            _plotModels.Add("CubicSplainSecondVariant", plotModel);
        }

        public void CubicSplainSecondVariantDerivative(IEnumerable<double> x_s,
            IEnumerable<double> y_s)
        {
            PlotView plotView = new PlotView();
            plotView.Dock = DockStyle.Fill;
            if (panel3_2.Controls.Count != 0)
                panel3_2.Controls.RemoveAt(0);
            panel3_2.Controls.Add(plotView);
            LinearAxis XAxis = new LinearAxis()
            {
                Position = AxisPosition.Bottom,
                Minimum = x_s.First(),
                Maximum = x_s.Last()
            };

            PlotModel plotModel = new PlotModel();
            plotView.Model = plotModel;

            var cubicSplain = CubicSplain.CreateCubicSplineSecond(x_s.ToList(), y_s.ToList());
            //точки от 0 до 301 
            List<double> plot_x = new List<double>();
            double step = (Math.Abs(x_s.First()) + Math.Abs(x_s.Last())) / N;
            for (int i = 0; i <= N; ++i)
            {
                plot_x.Add(x_s.First() + step * i);
            }

            List<double> cub_y = new List<double>();
            foreach (double x in plot_x)
            {
                cub_y.Add(cubicSplain.CalcFirstDerivative(x));
            }


            FunctionSeries functionSeries = new FunctionSeries();
            Series series = new LineSeries();
            for (int i = 0; i < plot_x.Count; ++i)
            {
                DataPoint dataPoint = new DataPoint(plot_x[i], cub_y[i]);
                functionSeries.Points.Add(dataPoint);
            }

            plotView.Model.Series.Add(functionSeries);
            if (_plotModels.ContainsKey("CubicSplainSecondVariantDerivative"))
            {
                _plotModels.Remove("CubicSplainSecondVariantDerivative");
            }
            _plotModels.Add("CubicSplainSecondVariantDerivative", plotModel);
        }

        private void OpenFile_Click(object sender, EventArgs e)
        {
            openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "txt only files (*.txt)|*.txt";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {

                _fileName = openFileDialog.FileName;
                fileName.Text = _fileName;

                SaveIntoPDF.Enabled = true;
                SaveToPNG.Enabled = true;
            }
        }

        private void SaveIntoPDF_Click(object sender, EventArgs e)
        {
            folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                foreach (var plotModel in _plotModels)
                {
                    using(var stream = File.Create(folderBrowserDialog.SelectedPath + "\\" + plotModel.Key + ".pdf"))
                    {
                        var pdfExporter = new PdfExporter() { Width = 600, Height = 400 };
                        pdfExporter.Export(plotModel.Value,stream);
                    }
                }
            }
        }

        private void SaveToPNG_Click(object sender, EventArgs e)
        {
            folderBrowserDialog = new FolderBrowserDialog();
            if(folderBrowserDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                foreach (var plotModel in _plotModels)
                {
                    using (var stream = File.Create(folderBrowserDialog.SelectedPath + "\\" + plotModel.Key + ".png"))
                    {
                        var pngExporter = new PngExporter() { Width = 600, Height = 400, Background = OxyColors.White };
                        pngExporter.Export(plotModel.Value, stream);
                    }
                }
            }
        }

        private void buttonRun_Click(object sender, EventArgs e)
        {
            N = int.Parse(textBoxN.Text);
            _plotModels.Clear();
            PaintGraphs();
        }

        private void textBoxN_TextChanged(object sender, EventArgs e)
        {
            if (textBoxN.Text.Any(x => !char.IsDigit(x)))
                textBoxN.Text = "300";
        }
    }
}
