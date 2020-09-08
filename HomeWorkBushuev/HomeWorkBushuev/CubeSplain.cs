using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkBushuev
{
    public class CubicSection
    {
        private double _cBegin;
        private double _cEnd;
        private double _lBegin;
        private double _lEnd;
        private double _tBegin;
        private double _tEnd;

        public CubicSection(double cBegin,
            double cEnd,
            double lBegin,
            double lEnd,
            double tBegin,
            double tEnd)
        {
            _cBegin = cBegin;
            _cEnd = cEnd;
            _lBegin = lBegin;
            _lEnd = lEnd;
            _tBegin = tBegin;
            _tEnd = tEnd;
        }

        public double Cbegin { get { return _cBegin; } }
        public double CEnd { get { return _cEnd; } }
        public double LBegin { get { return _lBegin; } }
        public double LEnd { get { return _lEnd; } }
        public double TBegin { get { return _tBegin; } }
        public double TEnd { get { return _tEnd; } }

        public double Calc(double x)
        {
            return _cBegin * Math.Pow((x - _tBegin), 3) +
                _cEnd * Math.Pow((_tEnd - x), 3) +
                _lBegin * (x - _tBegin) +
                _lEnd * (_tEnd - x);
        }

        public double CalcDerivative(double x)
        {
            return 3.0 * _cBegin * Math.Pow((x - _tBegin), 2) -
                3.0 * _cEnd * Math.Pow((_tEnd - x), 2) +
                _lBegin -
                LEnd;
        }

    }

    public class CubicSplain
    {
        private List<CubicSection> _sections;
        private List<double> _sectionBounds;

        public CubicSplain(List<double> sectionBounds,
            List<CubicSection> sections)
        {
            _sectionBounds = sectionBounds;
            _sections = sections;
        }

        public CubicSection Get(double value)
        {
            List<double> tempSectionBonds = 
                _sectionBounds.Skip(1).ToList();
            for (int i = 0; i < tempSectionBonds.Count; ++i)
            {
                if (value < tempSectionBonds[i])
                    return _sections[i];
            }

            return _sections.Last();
        }

        public double Calc(double x)
        {
            return Get(x).Calc(x);
        }

        public double CalcFirstDerivative(double x)
        {
            return Get(x).CalcDerivative(x);
        }

        public static List<double> SolveTridiagonal(List<double> a,
            List<double> b,
            List<double> c,
            List<double> d)
        {
            List<double> cm = new List<double>();
            List<double> dm = new List<double>();
            cm.Add(c.First() / b.First());
            dm.Add(d.First() / b.First());

            for (int i = 1; i < c.Count(); ++i)
            {
                double temp_c = c[i] / (b[i] - a[i - 1] * cm[i - 1]);
                cm.Add(temp_c);
            }
            for (int i = 1; i < b.Count(); ++i)
            {
                double temp_d = (d[i] - a[i - 1] * dm[i - 1])
                    / (b[i] - a[i - 1] * cm[i - 1]);
                dm.Add(temp_d);
            }
            List<double> result = new List<double>();
            result.Add(dm.Last());

            for (int i = 1; i < cm.Count() + 1; ++i)
            {
                double tmp = dm[cm.Count() - i] -
                    cm[cm.Count() - i] * result[i - 1];
                result.Add(tmp);
            }

            result.Reverse();
            return result;
        }

        public static CubicSplain CreateCubicSpline(List<double> x_s,
            List<double> y_s)
        {
            List<double> h = new List<double>();
            List<double> b = new List<double>();
            List<double> v = new List<double>();
            List<double> u = new List<double>();

            for (int i = 0; i < x_s.Count - 1; ++i)
            {
                h.Add(x_s[i + 1] - x_s[i]);
                b.Add((y_s[i + 1] - y_s[i]) / h.Last());
            }

            for (int i = 1; i < x_s.Count -1; ++i)
            {
                v.Add(2.0 * (h[i - 1] + h[i]));
                u.Add(6.0 * (b[i] - b[i - 1]));
            }

            //выбрать только внутренние значения, игнорим первую и последнюю
            List<double> sliced_h = 
                h.Skip(1).Take(h.Count - 2).ToList();

            var result = SolveTridiagonal(sliced_h, v, sliced_h, u);

            //первая производная точки равны 0
            List<double> z = new List<double>();
            z.Add(0.0);
            z = z.Concat(result).ToList();
            z.Add(0.0);

            List<CubicSection> sections = new List<CubicSection>();

            for (int i = 0; i < z.Count -1; ++i)
            {
                double cBegin = z[i + 1] / (6.0 * h[i]);
                double cEnd = z[i] / (6.0 * h[i]);
                double lBegin = y_s[i + 1] / h[i] - z[i + 1] * h[i] / 6.0;
                double lEnd = y_s[i] / h[i] - h[i] * z[i] / 6.0;
                double tBegin = x_s[i];
                double tEnd = x_s[i + 1];
                sections.Add(new CubicSection(cBegin,
                    cEnd,
                    lBegin,
                    lEnd,
                    tBegin,
                    tEnd));
            }

            CubicSplain cubicSplain = new CubicSplain(x_s,
                sections);
            return cubicSplain;
        }

        public static CubicSplain CreateCubicSplineSecond(List<double> x_s,
            List<double> y_s)
        {
            int n = x_s.Count;

            List<double> h = new List<double>();
            List<double> b = new List<double>();
            List<double> v = new List<double>();
            List<double> u = new List<double>();

            for (int i = 0; i < n - 1; ++i)
            {
                h.Add(x_s[i + 1] - x_s[i]);
                b.Add((y_s[i + 1] - y_s[i]) / h.Last());
            }

            for (int i = 1; i < n - 1; ++i)
            {
                v.Add(2.0 * (h[i - 1] + h[i]));
                u.Add(6.0 * (b[i] - b[i - 1]));
            }

            v[0] = 1.5 * h[0] + 2.0 * h[1];
            v[v.Count - 1] = 1.5 * h[h.Count() - 2] + 2.0 * h[h.Count() - 1];
            u[0] = u[0] - 3.0 * b[0];
            u[u.Count - 1] = u[u.Count() - 1] + 3.0 * b.Last();

            List<double> sliced_h = h.Skip(1).Take(h.Count() - 2).ToList();
            List<double> res = SolveTridiagonal(sliced_h, v, sliced_h, u);
            List<double> z = new List<double>();

            z.Add(0.5 * (6.0 * b.First() / h.First() - res.First()));
            z = z.Concat(res).ToList();
            z.Add(-0.5 * (6.0 * b.Last() / h.Last() + res.Last()));

            List<CubicSection> sections = new List<CubicSection>();

            for (int i = 0; i < z.Count() - 1; ++i)
            {
                double cBegin = z[i + 1] / (6.0 * h[i]);
                double cEnd = z[i] / (6.0 * h[i]);
                double lBegin = y_s[i + 1] / h[i] - z[i + 1] * h[i] / 6.0;
                double lEnd = y_s[i] / h[i] - h[i] * z[i] / 6.0;
                double tBegin = x_s[i];
                double tEnd = x_s[i + 1];

                CubicSection cubicSection = new CubicSection(cBegin,
                    cEnd,
                    lBegin,
                    lEnd,
                    tBegin,
                    tEnd);

                sections.Add(cubicSection);
            }

            CubicSplain cubicSplain = new CubicSplain(x_s,
                sections);
            return cubicSplain;
        }
    
    }
}
