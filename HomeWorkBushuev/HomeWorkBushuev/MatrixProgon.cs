using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkBushuev
{
    public class MatrixProgon
    {
        private List<List<double>> _matrix;
        private List<double> _d;
        private List<double> _alpha;
        private List<double> _beta;
        private List<double> _sigma;
        private Stack<double> _x;
        private int _precision;
        private bool _isCalculated = false;

        public MatrixProgon(List<List<double>> matrix,
            List<double> d,
            int precision = 3)
        {
            _matrix = matrix;
            _d = d;
            _precision = precision;
            _alpha = new List<double>();
            _beta = new List<double>();
            _sigma = new List<double>();
            _x = new Stack<double>();
        }

        private void CalculateCoefficients()
        {
            double tempSigma = 0.0;
            double tempAlpha = 0.0;
            double tempBeta = 0.0;
            double tempA = 0.0;
            double tempB = 0.0;
            double tempC = 0.0;
            double tempD = 0.0;

            for (int rowIndex = 0; rowIndex < _matrix.Count; ++rowIndex)
            {
                if (rowIndex == 0)
                {
                    tempSigma = Math.Round(_matrix.First().First(), _precision);
                    tempB = tempSigma;
                    tempC = Math.Round(_matrix.First().ElementAt(1), _precision);
                    tempAlpha = Math.Round((-1) * tempC / tempSigma, _precision);
                    tempD = _d.First();
                    tempBeta = Math.Round(tempD / tempSigma, _precision);

                    _sigma.Add(tempSigma);
                    _alpha.Add(tempAlpha);
                    _beta.Add(tempBeta);

                    continue;
                }

                if (rowIndex == _matrix.Count - 1)
                {
                    tempB = Math.Round(_matrix[rowIndex][rowIndex], _precision);
                    tempA = Math.Round(_matrix[rowIndex][rowIndex - 1], _precision);
                    tempSigma = Math.Round(tempB + tempA * _alpha.Last(), _precision);
                    tempD = Math.Round(_d[rowIndex], _precision);
                    tempBeta = Math.Round((tempD + (-1) * tempA * _beta.Last()) / tempSigma, _precision);
                    _beta.Add(tempBeta);
                    _sigma.Add(tempSigma);
                    continue;
                }


                tempB = _matrix[rowIndex][rowIndex];
                tempA = _matrix[rowIndex][rowIndex - 1];
                tempC = _matrix[rowIndex][rowIndex + 1];
                tempD = _d[rowIndex];

                tempSigma = Math.Round(tempB + tempA * _alpha.Last(), _precision);
                tempAlpha = Math.Round((-1) * tempC / tempSigma, _precision);
                tempBeta = Math.Round((tempD + (-1) * tempA * _beta.Last()) / tempSigma, _precision);

                _alpha.Add(tempAlpha);
                _beta.Add(tempBeta);
                _sigma.Add(tempSigma);
            }
        }

        public void Calculate()
        {
            CalculateCoefficients();
            double tempX;
            for (int index = _beta.Count - 1;
                index != -1;
                index--)
            {
                if (index == _beta.Count - 1)
                {
                    _x.Push(_beta.Last());
                    continue;
                }

                tempX = Math.Round(_alpha[index] * _x.Peek() + _beta[index], _precision);
                _x.Push(tempX);
            }
            _isCalculated = true;
        }
        public List<double> Alpha { get { if (!_isCalculated) Calculate(); return _alpha; } }

        public List<double> Beta { get { if (!_isCalculated) Calculate(); return _beta; } }

        public List<double> Sigma { get { if (!_isCalculated) Calculate(); return _sigma; } }

        public List<double> X { get { if (!_isCalculated) Calculate(); return _x.ToList(); } }
    }
}
