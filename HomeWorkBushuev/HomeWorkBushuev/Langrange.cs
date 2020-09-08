using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkBushuev
{
    public class Langrange
    {
        private List<double> _x_s = new List<double>();
        private List<double> _y_s = new List<double>();

        public Langrange(IEnumerable<double> x_s,
            IEnumerable<double> y_s)
        {
            _x_s = new List<double>(x_s);
            _y_s = new List<double>(y_s);
        }

        private double GetBasePolynominal(double x, int index_x)
        {
            double value = 1.0;
            for (int index = 0; index < _x_s.Count; ++index)
            {
                if (index_x != index)
                    value *= (x - _x_s[index]) /
                       (_x_s[index_x] - _x_s[index]);
            }
            return value;
        }

        public double GetLangrangePolynominal(double x)
        {
            double sum = 0;
            for (int index_x = 0; index_x < _x_s.Count; ++index_x)
            {
                sum += GetBasePolynominal(x, index_x) * _y_s[index_x];
            }
            return sum;
        }

        public double GetBaseDerive(double at_x,
            int index_x)
        {
            double b = 0.0;
            for (int index = 0; index < _x_s.Count; ++index)
            {
                if (index != index_x)
                {
                    b += 1.0 / (at_x - _x_s[index]);
                }
            }

            return b;
        }

        public double GetLangrangeFirstDerivative(double at_x)
        {
            List<double> basePolynom = new List<double>();
            for (int index_x = 0; index_x < _x_s.Count; ++index_x)
            {
                basePolynom.Add(GetBasePolynominal(at_x, index_x));
            }

            //производная 
            List<double> derivPolynom = new List<double>();
            for (int index_x = 0; index_x < _x_s.Count; ++index_x)
            {
                derivPolynom.Add(GetBaseDerive(at_x, index_x) * basePolynom[index_x]);
            }

            double sum = 0.0;
            for (int index = 0; index < derivPolynom.Count; ++index)
            {
                sum += derivPolynom[index] * _y_s[index];
            }

            return sum;
        }


        public double prod_exec(int i, int j, int m, double at_x)
        {
            double value = 1.0;
            for (int index = 0; index < _x_s.Count; ++index)
            {
                if (index == i ||
                    index == j ||
                    index == m)
                {
                    value *= 1.0;
                }
                else
                {
                    value *= (at_x - _x_s[index])
                        / (_x_s[i] - _x_s[index]);
                }
            }
            return value;
        }

        public double sum_exec(int i, int l, double at_x)
        {
            double value = 0.0;
            for (int index = 0; index < _x_s.Count; ++index)
            {
                if (index == i ||
                    index == l)
                    value += 0.0;
                else
                    value += prod_exec(i, l, index, at_x) /
                        (_x_s[i] - _x_s[index]);
            }
            return value;
        }


        public double lj_der_2(int j, double at_x)
        {
            double value = 0.0;
            for (int index = 0; index < _x_s.Count; ++index)
            {
                if (index == j)
                    value += 0.0;
                else
                    value += sum_exec(j, index, at_x) / (_x_s[j] - 0);
            }
            return value;
        }

        public double GetLangrangeSecondDerivative(double at_x)
        {
            double value = 0.0;
            for (int index = 0; index < _x_s.Count; ++index)
            {
                value += _y_s[index] * lj_der_2(index, at_x);
            }
            return value;
        }
    }
}
